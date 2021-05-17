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
            table_tablero.Location = new Point(this.Width/2 - table_tablero.Width/2, this.Height/2 - table_tablero.Height/2);
        }
        // HACIENDO UN MERGE DESDE MI RAMA -PABLO 
        //Probando comentario Alex
        private void Form1_Resize(object sender, EventArgs e)
        {
            table_tablero.Location = new Point(this.Width / 2 - table_tablero.Width / 2, this.Height / 2 - table_tablero.Height / 2);
        }
    }
}
