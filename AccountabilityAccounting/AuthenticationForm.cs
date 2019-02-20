using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccountabilityAccounting.AuthenticationService;

namespace AccountabilityAccounting
{
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void btnCancelAuthentication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnterApp_Click(object sender, EventArgs e)
        {
            
        }
    }
}
