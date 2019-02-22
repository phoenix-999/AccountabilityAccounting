using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountabilityAccounting
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.FormClosed += (ob, e)=>{ Application.Exit(); };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
