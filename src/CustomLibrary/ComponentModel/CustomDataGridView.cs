using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using CustomLibrary.Extensions.Collections;

namespace CustomLibrary.ComponentModel
{
    public class CustomDataGridView : DataGridView
    {
        private ListSortDirection[] _sortDirections;

        [Description("Color de fondo de datos las filas pares.")]
        public Color OddRowColor { get; set; }

        [Description("Color de fondo de datos las filas impares.")]
        public Color EvenRowColor { get; set; }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
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

        private void Ordenar(int columnIndex, ListSortDirection direction)
        {
            this.Sort(this.Columns[columnIndex], direction);
            _sortDirections[columnIndex] = direction;
            var order = direction == ListSortDirection.Ascending ? SortOrder.Descending : SortOrder.Ascending;
            this.Columns[columnIndex].HeaderCell.SortGlyphDirection = order;
        }

        protected override void OnColumnHeaderMouseClick(DataGridViewCellMouseEventArgs e)
        {
            base.OnColumnHeaderMouseClick(e);

            try
            {
                if (_sortDirections[e.ColumnIndex] == ListSortDirection.Ascending)
                {
                    Ordenar(e.ColumnIndex, ListSortDirection.Descending);
                }
                else
                {
                    Ordenar(e.ColumnIndex, ListSortDirection.Ascending);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(String.Format(
                    "Error en OnColumnHeaderMouseClick \n Columna {0} \n Cantidad de columnas {1} \n Sort directions {2}",
                    e.ColumnIndex, Columns.Count, _sortDirections.Count()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetRow(Func<DataGridViewRow, bool> condición)
        {
            if (Extensions.Controls.DataGridViewExtensions.SetRow(this, condición))
            {
                OnSelectionChanged(EventArgs.Empty);
            }
        }

        public void SetDataSource<T>(IEnumerable<T> query)
        {
            DataSource = query.ToSortableBindingList();
            Inicializar();
        }

        public void SetDataSource<T, T2>(IEnumerable<T2> query, Func<T2, T> convert)
        {
            DataSource = query.ToSortableBindingList(convert);
            Inicializar();
        }

        private void Inicializar()
        {
            _sortDirections = new ListSortDirection[Columns.Count];
            for (int i = 0; i < Columns.Count; i++)
            {
                _sortDirections[i] = default(ListSortDirection);
            }
        }
    }
}
