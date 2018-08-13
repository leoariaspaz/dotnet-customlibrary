using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Controles.Grilla
{
    public class CustomDataGridView : DataGridView
    {
        private SortOrder[] _sortDirections;

        [Description("Color de fondo de datos las filas pares.")]
        public Color OddRowColor { get; set; }

        [Description("Color de fondo de datos las filas impares.")]
        public Color EvenRowColor { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            _sortDirections = new SortOrder[Columns.Count];
            for (int i = 0; i < Columns.Count; i++)
            {
                _sortDirections[i] = SortOrder.None;
            }
        }

        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);
            if (e.RowIndex % 2 == 0)
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = EvenRowColor;
            }
            else
            {
                Rows[e.RowIndex].DefaultCellStyle.BackColor = OddRowColor;
            }
        }

        protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnColumnHeaderMouseClick(e);
            var item = _sortDirections[e.ColumnIndex];
            if (item == SortOrder.Ascending)
            {
                this.Sort(this.Columns[e.ColumnIndex], ListSortDirection.Descending);
                item = SortOrder.Descending;
            }
            else
            {
                this.Sort(this.Columns[e.ColumnIndex], ListSortDirection.Ascending);
                item = SortOrder.Ascending;
            }
            _sortDirections[e.ColumnIndex] = item;
        }
    }
}
