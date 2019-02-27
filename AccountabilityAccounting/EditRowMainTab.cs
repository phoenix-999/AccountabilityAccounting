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

        DataTable Table { get; set; }
        public EditRowMainTab(DataGridViewRow row, DataTable table)
        {
            InitializeComponent();

            this.Row = row;
            this.Table = table;


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

    }
}
