using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattelShip
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            table_tablero.Location = new Point(this.Width/3 - table_tablero.Width/2, this.Height/2 - table_tablero.Height/2);

            crearLabels();
        }
      

        private void Form1_Resize(object sender, EventArgs e)
        {
            table_tablero.Location = new Point(this.Width / 3 - table_tablero.Width / 2, this.Height / 2 - table_tablero.Height / 2);
        }

        private void crearLabels()
        {
            int totalCols = table_tablero.ColumnCount;
            int totalRows = table_tablero.RowCount;

            for (int i = 0; i < totalCols; i++)
            {
                for (int u = 0; u < totalRows; u++)
                {
                    Label lab = new Label();
                    lab.Dock = DockStyle.Fill;

                    lab.Text = u + "" + i;
                    lab.TextAlign = ContentAlignment.MiddleCenter;
                    table_tablero.Controls.Add(lab, i, u);
                }

            }
        }

    }

}
