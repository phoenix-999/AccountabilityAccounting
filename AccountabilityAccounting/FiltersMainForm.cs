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
            HashSet<string> values = new HashSet<string>();
            values.Add("Все");
            for(int row = 0; row < table.Rows.Count; row++)
            {
                for(int column = 0; column < table.Columns.Count; column++)
                {
                    if(table.Columns[column].ColumnName == columnName)
                    {
                        values.Add(table.Rows[row][column].ToString());
                    }
                }
            }

            comboBox.Items.AddRange(values.ToArray<string>());
            comboBox.SelectedIndex = 0;
        }
    }
}
