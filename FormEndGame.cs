using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        // El video debe estar en bin/debug;
            FinishVideo.URL = System.IO.Path.Combine(
                           System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                           "Fin_Battleship.mp4");
        }

        private void TiempoVideo_Tick(object sender, EventArgs e)
        {
            
            if (count > 7) {
                TiempoVideo.Stop();
                Form2_PantallaInicial form2 = new Form2_PantallaInicial();
                form2.Show();
                //FinishVideo.close();
                Hide();
            }
            else
            {
                count++;
            }
        }
    }
}
