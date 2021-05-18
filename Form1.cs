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

        List<string> nombresCasillas;

        public Form1()
        {
            InitializeComponent();
            table_tablero.Location = new Point(this.Width/3 - table_tablero.Width/2, this.Height/2 - table_tablero.Height/2);
            table_tablero.BackColor = Color.FromArgb(116, 185, 255);
            nombresCasillas = new List<string>();
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
                    PictureBox pic_Box = new PictureBox();
                    pic_Box.Dock = DockStyle.Fill;
                    pic_Box.AllowDrop = true;

                    void pic_Box_DragEnter(object sender, DragEventArgs e)
                    {
                        //metodo comprobar casilla
                        if(comprobarCasilla(""))
                        {
                            pic_Box.BackColor = Color.FromArgb(32, 191, 107);
                        }
                        else
                        {
                            pic_Box.BackColor = Color.FromArgb(252, 92, 101);
                        }

                        
                        e.Effect = DragDropEffects.Copy;
                    }

                    void pic_Box_DragLeave(object sender, EventArgs e)
                    {
                        pic_Box.BackColor = Color.FromArgb(116, 185, 255);
                    }

                    void pic_Box_DragDrop(object sender, DragEventArgs e)
                    {
                        //pic_Box.BackgroundImage = (Image)e.Data.GetData(DataFormats.Bitmap);
                        pic_Box.BackColor = Color.FromArgb(116, 185, 255);
                        Console.WriteLine(pic_Box.Name);
                        nombresCasillas.Add(pic_Box.Name);
                    }

                    pic_Box.DragEnter += new DragEventHandler(pic_Box_DragEnter);
                    pic_Box.DragLeave += new EventHandler(pic_Box_DragLeave);
                    pic_Box.DragDrop += new DragEventHandler(pic_Box_DragDrop);

                    pic_Box.Name = "pic_Box" + u + "" + i;
                    pic_Box.BackgroundImageLayout = ImageLayout.Stretch;

                    //picBox.Text = u + "" + i;
                    table_tablero.Controls.Add(pic_Box, i, u);

                    //Console.WriteLine(pic_Box.Name);

                }

            }

        }

        private bool comprobarCasilla(String casilla)
        {
            return false;
        }

        private void pic_Carrier_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(pic_Carrier.BackgroundImage, DragDropEffects.Copy);
        }
    }

}
