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
using NLog;
using System.Transactions;

namespace AccountabilityAccounting
{

    public partial class MainForm : Form
    {
        protected static readonly Logger Log = LogManager.GetCurrentClassLogger();

        DataProviderService.DataProviderClient dataProviderClient;
        FiltersMainForm Filters;

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

                dataGridViewMainTab.CellDoubleClick += (ob, ev) => { new EditRowMainTab(dataGridViewMainTab.CurrentRow, tableDataGridViewMainTab, dataProviderClient).Show(); };

                this.btnNewString.Click += new System.EventHandler(this.btnNewString_Click);

                this.btnDeleteString.Click += new System.EventHandler(this.btnDeleteString_Click);

                CreateFilters();
            }
            catch (FaultException<SecurityTokenException> ex)
            {
                MessageBox.Show("Вход в программу не выполнен", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (FaultException<DataProviderService.DbException> ex)
            {
                MessageBox.Show("Ошибка в работе с базой данных. Обратитесть к администратору.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CreateFilters()
        {
            Dictionary<string, ComboBox> filtersDict = new Dictionary<string, ComboBox>();
            filtersDict.Add("Проект", cmbProjects);
            filtersDict.Add("Статья", cmbItems);
            filtersDict.Add("Подотчетник", cmbAccountables);
            Filters = new FiltersMainForm(tableDataGridViewMainTab, filtersDict);
            Filters.CreateFilters();

           
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

            asc += "\nПосле применения изменения не обратимы.";

            DialogResult dialogResult = MessageBox.Show(asc, "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                tableDataGridViewMainTab.Rows[index].Delete();
            }          
        }

        private void tbSendToDB_Click(object sender, EventArgs e)
        {
            if (dataProviderClient == null)
                return;

            if(!CheckEmptyValues(dataGridViewMainTab))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                        
            DataProviderService.Updater updater = new Updater();
            updater.UpdaterOption = UpdaterOptions.UpdateSummary;
           
                try
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        dataProviderClient.UpdateData(updater, tableDataGridViewMainTab, (DataProviderService.User)AuthenticationService.User.Current);
                        transaction.Complete();
                        tableDataGridViewMainTab.AcceptChanges();
                    MessageBox.Show("Все изменения успешно применены");
                    }                 
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

        private bool CheckEmptyValues(DataGridView grid)
        {
            bool result = true;
            for(int rowIndex = 0; rowIndex < grid.RowCount; rowIndex++)
            {
                var row = grid.Rows[rowIndex];
                for(int columnIndex = 0; columnIndex < grid.ColumnCount; columnIndex++)
                {
                    if (row.Cells[columnIndex].OwningColumn.Name == "Расшифровка")
                        continue;

                    if(row.Cells[columnIndex].Value.ToString() == string.Empty)
                    {
                        row.Cells[columnIndex].Style.BackColor = Color.Red;
                        result = false;
                    }
                    else
                    {
                        row.Cells[columnIndex].Style.BackColor = Color.White;
                    }
                }
            }

            return result;
        }

        private void DataError_EventHandler(object ob, EventArgs e)
        {
            MessageBox.Show("Ошибка при заполнении полей данных. Изменения отменены.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        

        private void filters_click(object sender, EventArgs e)
        {
            try
            {
                CreateFilters();
            }
            catch { } // Перехват исключения при случайно нажатом комбобоксе до полечения данных из сервера
        }

        private void btnAcceptFilters_Click(object sender, EventArgs e)
        {

                Filters.SetUpFilters();

        }
    }
}
