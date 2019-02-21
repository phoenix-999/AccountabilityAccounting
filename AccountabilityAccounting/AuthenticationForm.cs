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
using System.IdentityModel.Tokens;
using System.ServiceModel;

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
            AuthenticationClient authencticationClient = new AuthenticationClient();
            try
            {
                User user = authencticationClient.Authenticate(tbLogin.Text, tbPassword.Text);
                //Данные сохраняются в статическом свойстве только для чтения
                new UserData(user);
            }
            catch (FaultException<SecurityTokenException> ex)
            {
                MessageBox.Show("Вход не выполнен. Проверте логин и пароль.");
                Application.Exit();
                
            }
        }
    }
}
