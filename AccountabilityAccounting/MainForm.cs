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

                // TODO добавить выпадающий список в столбцы
                
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


        
    }
}
