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

            EditRowMainTabSourceForm.CreateChildrenGrid(this, SelectorOptions.GetSign, this.dataGridViewSigns, EditRowMainTabSourceForm.tbSign);
        }

       
    }
}
