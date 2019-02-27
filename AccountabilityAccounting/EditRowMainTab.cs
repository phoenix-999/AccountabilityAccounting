using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using AccountabilityAccounting.DataProviderService;
using System.ServiceModel;
using System.IdentityModel.Tokens;
using NLog;

namespace AccountabilityAccounting
{
    public partial class EditRowMainTab : Form
    {
        DataGridViewRow Row { get; set; }

        DataTable Table { get; set; }

        protected static readonly Logger Log = LogManager.GetCurrentClassLogger();

        private DataProviderService.DataProviderClient DataProviderClient;

        public EditRowMainTab(DataGridViewRow row, DataTable table, DataProviderService.DataProviderClient dataProviderClient)
        {
            InitializeComponent();

            this.Row = row;
            this.Table = table;
            this.DataProviderClient = dataProviderClient;


            dtpDate.Text = Row.Cells["Дата"].Value.ToString();
            tbSign.Text = Row.Cells["Приход/Расход"].Value.ToString();
            tbProject.Text = Row.Cells["Проект"].Value.ToString();
            tbAccounting.Text = Row.Cells["Подотчетник"].Value.ToString();
            tbItem.Text = Row.Cells["Статья"].Value.ToString();
            tbTranscriptItem.Text = Row.Cells["Расшифровка"].Value.ToString();
            tbSum.Text = Row.Cells["Сумма"].Value.ToString();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAccept_Click(object sender, EventArgs e)
        {
            if(!CheckEmtyValues())
            {
                return;
            }

            Row.Cells["Дата"].Value = dtpDate.Text;
            Row.Cells["Приход/Расход"].Value = tbSign.Text;
            Row.Cells["Проект"].Value = tbProject.Text;
            Row.Cells["Подотчетник"].Value = tbAccounting.Text;
            Row.Cells["Статья"].Value = tbItem.Text;
            Row.Cells["Расшифровка"].Value = tbTranscriptItem.Text;
            Row.Cells["Сумма"].Value = tbSum.Text;

            this.Close();

        }

        private void SetComboboxOptions(ComboBox comboBox, DataTable table, string columnName)
        {
            HashSet<string> options = new HashSet<string>();

            foreach(DataRow  row in table.Rows)
            {
                options.Add(row[columnName].ToString());
            }

            foreach(string item in options)
            {
                comboBox.Items.Add(item);
            }
        }

        private void btnSigns_Click(object sender, EventArgs e)
        {
            SignsForm signForm = new SignsForm(DataProviderClient, this);
            signForm.Show();
        }

        private bool CheckEmtyValues()
        {
            bool result = true; ;

            if(this.tbSum.Text == string.Empty)
            {
                this.tbSum.BackColor = Color.Red;
                result = false;
            }
            else
            {
                this.tbSum.BackColor = Color.White;
            }

            if(!result)
            {
                MessageBox.Show("Вы заполнили не все обязательные поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        public void CreateChildrenGrid(Form form, DataProviderService.SelectorOptions selectorOptions, DataGridView grid, TextBox tb)
        {
            DataProviderService.Selector selector = new DataProviderService.Selector();
            selector.SelectorOption = selectorOptions;
            try
            {
                DataTable table = DataProviderClient.GetData(selector, (DataProviderService.User)AuthenticationService.User.Current);
                grid.DataSource = table;
                grid.CellDoubleClick += (ob, ea) => { tb.Text = grid.CurrentCell.Value.ToString(); form.Close(); };
            }
            catch (FaultException<SecurityTokenException> ex)
            {
                MessageBox.Show("Вход в программу не выполнен", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FaultException<DataProviderService.DbException> ex)
            {
                MessageBox.Show("Ошибка в работе с базой данных. Обратитесть к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CommunicationException ex)
            {
                Log.Error("Detail: {1}", ex.ToString());
                MessageBox.Show("Ошибка обращения к серверу. Обратитесь к администартору", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            ProjectsForm projForm = new ProjectsForm(DataProviderClient, this);
            projForm.Show();
        }
    }
}
