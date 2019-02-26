using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountabilityAccounting.DataProviderService;
using AccountabilityAccounting.AuthenticationService;
using System.IdentityModel.Tokens;
using System.ServiceModel;
using System.Data;
using System.Globalization;

namespace AccountabilityAccounting
{
    public partial class MainForm : Form
    {
        DataProviderService.DataProviderClient dataProviderClient;

        DataTable tableDataGridViewMainTab;
        public MainForm()
        {
            InitializeComponent();

            this.FormClosed += (ob, e)=>{ Application.Exit(); };

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMainTabGetData_Click(object sender, EventArgs e)
        {
            dataProviderClient = new DataProviderClient();

            DataProviderService.Selector selector = new Selector();
            selector.SelectorOption = SelectorOptions.GetSummary;
            selector.Predicates = new Dictionary<string, string>(); 

            selector.Predicates.Add("dateStart", dtBegin.Value.ToString());
            selector.Predicates.Add("dateEnd", dtEnd.Value.ToString());

            try
            {
                tableDataGridViewMainTab = dataProviderClient.GetData(selector, (DataProviderService.User)AuthenticationService.User.Current);

                dataGridViewMainTab.DataSource = tableDataGridViewMainTab;

                dataGridViewMainTab.SelectionChanged += DataGridViewMainTab_SelectionChanged;

                dataGridViewMainTab.Columns["Сумма"].DefaultCellStyle.Format = string.Format("C2", new CultureInfo("uk-UA"));

                dataGridViewMainTab.CellDoubleClick += (ob, ev) => { new EditRowMainTab(dataGridViewMainTab.CurrentRow).Show(); };

                this.btnNewString.Click += new System.EventHandler(this.btnNewString_Click);

                this.btnDeleteString.Click += new System.EventHandler(this.btnDeleteString_Click);
            }
            catch (FaultException<SecurityTokenException> ex)
            {
                MessageBox.Show("Вход в программу не выполнен", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
            catch (FaultException<DataProviderService.DbException> ex)
            {
                MessageBox.Show("Ошибка в работе с базой данных. Обратитесть к администратору.", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();

            }
        }

        private void DataGridViewMainTab_SelectionChanged(object sender, EventArgs e)
        {
            lbCount.Text = string.Format("Колиество: {0}", dataGridViewMainTab.SelectedCells.Count);
            if(dataGridViewMainTab.SelectedCells.Count <= 1)
            {
                lbCount.Text = string.Empty;
            }

            double sum = 0;

            foreach(DataGridViewCell cell in dataGridViewMainTab.SelectedCells)
            {
                if (cell.Value.ToString() == string.Empty)
                    continue;
                try
                {
                    sum += double.Parse(cell.Value.ToString());
                }
                catch(Exception ex)
                {
                    sum = double.NaN;
                }
            }

            if(!double.IsNaN(sum))
            {
                lbSum.Text = string.Format("Сумма: {0}", sum.ToString("C2", new CultureInfo("uk-UA")));
            }

            if (dataGridViewMainTab.SelectedCells.Count <= 1)
            {
                lbSum.Text = string.Empty;
            }
        }

        private void btnNewString_Click(object sender, EventArgs e)
        {
            DataRow row = tableDataGridViewMainTab.Rows.Add();
        }

        private void btnDeleteString_Click(object sender, EventArgs e)
        {
            string asc = "Вы уверены, что хотите удалить строку со значениями: ";
            
            int index = dataGridViewMainTab.CurrentRow.Index;

            foreach(DataGridViewCell cell in dataGridViewMainTab.CurrentRow.Cells)
            {
                asc += string.Format("{0} - {1}\n", cell.OwningColumn.Name, cell.Value);
            }

            asc += "После применения изменения не обратимы.";

            DialogResult dialogResult = MessageBox.Show(asc, "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tableDataGridViewMainTab.Rows[index].Delete();
            }          
        }
    }
}
