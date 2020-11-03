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
    public partial class Form6 : Form
    {
        int Col = 1;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 6;
            dataGridView1.Rows[0].HeaderCell.Value = "1";
            dataGridView1.Rows[1].HeaderCell.Value = "1";

            dataGridView1.Rows[2].HeaderCell.Value = "2";
            dataGridView1.Rows[3].HeaderCell.Value = "2";

            dataGridView1.Rows[4].HeaderCell.Value = "3";
            dataGridView1.Rows[5].HeaderCell.Value = "3";


        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Col <= 4) {
                dataGridView1.CurrentCell.Style.BackColor = Color.Orange;
                Col++;
            }
            else
                dataGridView1.CurrentCell.Style.BackColor = Color.Yellow;

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex %2 == 0 && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
 & ~DataGridViewPaintParts.Border);
                using (Pen p = new Pen(Color.Black, 1))

                {

                    Rectangle rect = e.CellBounds;

                    rect.Width -= 1;

                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(p, rect);

                }
                e.Handled = true;

            }
            else
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All
                 & ~DataGridViewPaintParts.Border);
                using (Pen p = new Pen(Color.White, 1))

                {

                    Rectangle rect = e.CellBounds;

                    rect.Width -= 1;

                    rect.Height -= 1;

                    e.Graphics.DrawRectangle(p, rect);

                }
                e.Handled = true;
            }
            if(e.ColumnIndex % 2 != 0 && e.RowIndex >= 0)
            {
                using (Pen p = new Pen(Color.Black, 4))
                {
                    e.Graphics.DrawLine(p, e.CellBounds.Right, e.CellBounds.Top, e.CellBounds.Right, e.CellBounds.Bottom);
                    // e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom, e.CellBounds.Right, e.CellBounds.Bottom);

                }

                e.Handled = true;
            }
            if (e.ColumnIndex >= 0 && e.RowIndex % 2 != 0)
            {
                using (Pen p = new Pen(Color.Black, 4))
                {
                    
                     e.Graphics.DrawLine(p, e.CellBounds.Left, e.CellBounds.Bottom, e.CellBounds.Right, e.CellBounds.Bottom);

                }

                e.Handled = true;
            }



        }
    }
}
