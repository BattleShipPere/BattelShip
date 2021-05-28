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
    public partial class Form3 : Form
    {
        int totalCols;
        int totalRows;
        int fallos = 0;
        Color red = Color.FromArgb(252, 92, 101);
        Color green = Color.FromArgb(32, 191, 107);
        Color blue = Color.FromArgb(116, 185, 255);
        List<Barcos> barcos = new List<Barcos>();

        public Form3(List<Object> barc)
        {
            InitializeComponent();
            table_tablero.BackColor = Color.Transparent;
            totalCols = table_tablero.ColumnCount;
            totalRows = table_tablero.RowCount;
            foreach(Barcos b in barc)
            {
                this.barcos.Add(b);
            }
            CrearPicBoxs();
        }

        private void CrearPicBoxs()
        {
            for (int i = 0; i < totalCols; i++)
            {
                for (int u = 0; u < totalRows; u++)
                {
                    PictureBox pic_Box = new PictureBox();
                    pic_Box.BackColor = blue;
                    pic_Box.Dock = DockStyle.Fill;
                    pic_Box.SizeMode = PictureBoxSizeMode.StretchImage;                   
                    pic_Box.Name = i + "" + u;
                    void pic_Box_Click(Object sender, EventArgs e)
                    {
                        sounds.Disparo.Play();
                        comprobarDisparo(pic_Box);
                        if(fallos > 20)
                        {
                            MessageBox.Show("HAS PERDIDO");
                            EndGame formEG = new EndGame();
                            formEG.Show();
                            //Form2_PantallaInicial form2 = new Form2_PantallaInicial();
                            //form2.Show();
                            Hide();
                        }
                        else
                        {
                            if (comprobarVictoria())
                            {
                                MessageBox.Show("HAS GANADO");
                                EndGame formEG = new EndGame();
                                formEG.Show();
                                //Form2_PantallaInicial form2 = new Form2_PantallaInicial();
                                //form2.Show();
                                Hide();
                            }
                        }
                        pic_Box.Enabled = false;
                    }
                    pic_Box.MouseClick += new MouseEventHandler(pic_Box_Click);
                    table_tablero.Controls.Add(pic_Box, i, u);
                }
            }
        }

        private bool comprobarDisparo(PictureBox pic_box)
        {
            bool tocado = false;
            foreach(Barcos b in barcos)
            {
                if (b.getPosicionCelda().Contains(pic_box.Name))
                {
                    b.getPosicionCelda().RemoveAt(b.getPosicionCelda().IndexOf(pic_box.Name));
                    pic_box.BackColor = red;
                    tocado = true;
                    sonidoTocado.Start();
                    return true;                
                }
            }
            if(!tocado) {
                fallos++;
                labelFallos.Text = "Fallos: " + fallos;
                pic_box.BackColor = Color.Transparent;
                sonidoAgua.Start();
            }
            return tocado;
        }

        private bool comprobarVictoria()
        {
            foreach (Barcos b in barcos)
            {
                if(b.getPosicionCelda().Count != 0)
                {
                    return false;
                } 
            }
            return true;
        }

        private void sonidoTocado_Tick(object sender, EventArgs e)
        {
            sounds.Tocado.Play();
            volverMusica.Start();
            sonidoTocado.Stop();
        }

        private void sonidoAgua_Tick(object sender, EventArgs e)
        {
            sounds.Agua.Play();
            volverMusica.Start();
            sonidoAgua.Stop();
        }

        private void volverMusica_Tick(object sender, EventArgs e)
        {
            sounds.Musica.Play();
            volverMusica.Stop();
        }
    }
}
