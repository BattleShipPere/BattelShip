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
    public partial class EndGame : Form
    {
        private int count = 0;

        public EndGame()
        {
            InitializeComponent();

            
    }

        private void TiempoVideo_Tick(object sender, EventArgs e)
        {
           
            if (count > 20) {
                TiempoVideo.Stop();
                Form2_PantallaInicial form2 = new Form2_PantallaInicial();
                form2.Show();

                Hide();
            }
            else
            {
                count++;
            }
        }
    }
}
