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

namespace AccountabilityAccounting
{
    public partial class EditRowMainTab : Form
    {
        DataGridViewRow Row { get; set; }
        public EditRowMainTab(DataGridViewRow row)
        {
            InitializeComponent();

            this.Row = row;

            tbDate.Text = Row.Cells["Дата"].Value.ToString();
            tbSign.Text = Row.Cells["Знак"].Value.ToString();
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
            Row.Cells["Дата"].Value = tbDate.Text;
            Row.Cells["Знак"].Value = tbSign.Text;
            Row.Cells["Проект"].Value = tbProject.Text;
            Row.Cells["Подотчетник"].Value = tbAccounting.Text;
            Row.Cells["Статья"].Value = tbItem.Text;
            Row.Cells["Расшифровка"].Value = tbTranscriptItem.Text;
            Row.Cells["Сумма"].Value = tbSum.Text;

            this.Close();
        }
    }
}
