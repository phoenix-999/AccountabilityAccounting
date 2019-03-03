using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace AccountabilityAccounting
{
    class FiltersMainForm 
    {
        DataTable Table { get; set; }
        Dictionary<string, ComboBox> Filters { get; set; }
        public FiltersMainForm(DataTable table, Dictionary<string, ComboBox> filters)
        {
            Table = table;
            Filters = filters;
        }

        public void CreateFilters()
        {
            foreach(var key in Filters.Keys)
            {
                AddFilter(Table, key, Filters[key]);
            }
        }

        private void AddFilter(DataTable table, string columnName, ComboBox comboBox)
        {
            comboBox.Items.Clear();
            HashSet<string> values = new HashSet<string>();
            values.Add("Все");
            for(int row = 0; row < table.Rows.Count; row++)
            {
                if(table.Rows[row].RowState == DataRowState.Deleted)
                {
                    continue;
                }
                for(int column = 0; column < table.Columns.Count; column++)
                {
                    if(table.Columns[column].ColumnName == columnName)
                    {
                        values.Add(table.Rows[row][column].ToString());
                    }
                }
            }

            comboBox.Items.AddRange(values.ToArray<string>());
            //comboBox.SelectedIndex = 0;
        }

        public void SetUpFilters()
        {
            Table.DefaultView.RowFilter = string.Format("'sfdfsdf' is not null");
            foreach(string key in Filters.Keys)
            {
                if(Filters[key].Text == "Все" || Filters[key].Text == string.Empty)
                {
                    Table.DefaultView.RowFilter += string.Format(" and ([{0}] is not null or [{0}] is null) ", key);
                    continue;
                }
                Table.DefaultView.RowFilter += string.Format(" and [{0}] like '{1}' ", key, Filters[key].Text);
            }
        }
    }
}
