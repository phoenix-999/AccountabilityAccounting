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
using System.ServiceModel;
using System.IdentityModel.Tokens;
using NLog;

namespace AccountabilityAccounting
{
    public partial class SignsForm : Form
    {
        private DataProviderService.DataProviderClient DataProviderClient { get; set; }
        EditRowMainTab EditRowMainTabSourceForm { get; set; }
        DataTable SignsTable { get; set; }

        protected static readonly Logger Log = LogManager.GetCurrentClassLogger();

        public SignsForm(DataProviderService.DataProviderClient dataProviderClient, Form sourceForm)
        {
            InitializeComponent();
            this.SignsTable = new DataTable();
            this.DataProviderClient = dataProviderClient;
            this.EditRowMainTabSourceForm = sourceForm as EditRowMainTab;

            SetDataOnGrid();
        }

        private void SetDataOnGrid()
        {
            DataProviderService.Selector selector = new DataProviderService.Selector();
            selector.SelectorOption = DataProviderService.SelectorOptions.GetSign;
            try
            {
                SignsTable = DataProviderClient.GetData(selector, (DataProviderService.User)AuthenticationService.User.Current);
                this.dataGridViewSigns.DataSource = SignsTable;
                this.dataGridViewSigns.CellDoubleClick += (ob, ea) => { EditRowMainTabSourceForm.tbSign.Text = this.dataGridViewSigns.CurrentCell.Value.ToString(); this.Close();  };
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
    }
}
