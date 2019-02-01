using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomLibrary.Extensions.Collections;

namespace CustomLibrary.Extensions.Controls
{
    public static class DataGridViewExtensions
    {
        public static void SetDataSource<T>(this DataGridView grid, IEnumerable<T> query)
        {
            grid.DataSource = query.ToSortableBindingList();
        }

        public static void SetDataSource<T, T2>(this DataGridView grid, IEnumerable<T2> query, 
            Func<T2, T> convert)
        {
            grid.DataSource = query.ToSortableBindingList(convert);
        }

        public static bool SetRow(this DataGridView grid, Func<DataGridViewRow, bool> condición)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (condición(row))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            if (rowIndex >= 0)
            {
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    if (grid.Columns[i].Visible)
                    {
                        grid.CurrentCell = grid.Rows[rowIndex].Cells[i];
                        return true;
                    }
                }                
            }
            return false;
        }
    }
}
