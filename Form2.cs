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
    public partial class Form2_PantallaInicial : Form
    {
        public Form2_PantallaInicial()
        {
            InitializeComponent();
            musica.settings.setMode("loop", true);
            musica.URL = System.IO.Path.Combine(
                            System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                            "music.wav");       
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            Hide();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Start_MouseHover(object sender, EventArgs e)
        {      
            this.Button_Start.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Start_Selec;
        }

        private void Button_Start_MouseLeave(object sender, EventArgs e)
        {
            this.Button_Start.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Start;
        }

        private void Button_Exit_MouseHover(object sender, EventArgs e)
        {
            this.Button_Exit.BackgroundImage = global::BattelShip.Properties.Resources.ExitBlack;
        }

        private void Button_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.Button_Exit.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Exit;
        }
    }
}
