using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportir
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            dataGridView1.RowCount = 3;
            dataGridView2.RowCount = 1;
            dataGridView3.RowCount = 3;
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex % 2 != 0

               && e.RowIndex>=0)

            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All
 & ~DataGridViewPaintParts.Border);

                using (Pen p = new Pen(Color.Gray, 1))

                {

                    Rectangle rect = e.CellBounds;

                    rect.Width -= 1;

                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(p, rect);

                }
                using (Pen p = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(p, e.CellBounds.Right, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Bottom);
                    e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom, e.CellBounds.Right, e.CellBounds.Bottom);

                }

                    e.Handled = true;

            }
            else
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
& ~DataGridViewPaintParts.Border);

                using (Pen p = new Pen(Color.Gray, 1))

                {

                    Rectangle rect = e.CellBounds;

                    rect.Width -= 1;

                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(p, rect);

                }
                using (Pen p = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom, e.CellBounds.Right, e.CellBounds.Bottom);

                }
                e.Handled = true;
            }
        }
    }
}
