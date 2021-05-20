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
        List<Control> casillasCorrectas = new List<Control>();  // Ubicaciones no guardadas
        List<Control> casillasMarcadas = new List<Control>();  // Ubicaciones de Barcos.

    // True == Eje X ; False == Eje Y
        bool eje = true; 

    //Colores
        Color red = Color.FromArgb(252, 92, 101);
        Color green = Color.FromArgb(32, 191, 107);
        Color blue = Color.FromArgb(116, 185, 255);

    //Barcos sin posicion
        Barcos portaviones = new Barcos(4, "portaviones");

        Barcos submarino1 = new Barcos(3, "submarino1");
        Barcos submarino2 = new Barcos(3, "submarino2");

        Barcos destructor1 = new Barcos(2, "destructor1");
        Barcos destructor2 = new Barcos(2, "destructor2");
        Barcos destructor3 = new Barcos(2, "destructor3");

        Barcos patrullero1 = new Barcos(1, "patrullero1");
        Barcos patrullero2 = new Barcos(1, "patrullero2");
        Barcos patrullero3 = new Barcos(1, "patrullero3");
        Barcos patrullero4 = new Barcos(1, "patrullero4");

        public Form1()
        {
            InitializeComponent();

            table_tablero.BackColor = blue;

            CrearPicBoxs();
        }
    //Crea todos los picture box en el table_tablero y sus eventos Drag & Drop
        private void CrearPicBoxs()
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

                //Creamos para los pic_Box el evento DragEnter
                    void pic_Box_DragEnter(object sender, DragEventArgs e)
                    {
                    // Si la casilla esta ocupada no pasa nada
                        if (estaMarcada(pic_Box)) return;
                    // Si no, llama al metodo posicion barco
                        posicionBarco(pic_Box);
                    // Habilita la mecanica de Drag & Drop
                        e.Effect = DragDropEffects.Copy;
                    }

                    //Creamos para los pic_Box el evento DragLeave
                    void pic_Box_DragLeave(object sender, EventArgs e)
                    {
                    // Si la casilla esta ocupada no pasa nada
                        if (estaMarcada(pic_Box)) return;
                    // Si la casilla es roja vuelve a azul
                        if(pic_Box.BackColor == red)
                        {
                            pic_Box.BackColor = blue;
                            return;
                        }
                    // Si no, pintamos todas las casillas de azul...
                        foreach (Control con in casillasCorrectas)
                        {
                            con.BackColor = blue;
                        } 
                    // ... y volvemos a pintar las ocupadas de verde  
                        foreach(Control con in casillasMarcadas){
                            con.BackColor = green;
                        }
                    }

                    // Creamos para los pic_Box el evento DragDrop
                    void pic_Box_DragDrop(object sender, DragEventArgs e)
                    {
                    // Si esta ocupada no pasa nada
                        if (estaMarcada(pic_Box)) return;
                    // Si la posicion es valida guardamos la posicion
                        if (pic_Box.BackColor == green)
                        {
                            guardarCasillas(pic_Box);

                        /*  Muestra casillas marcadas al hacer drop valido
                            foreach(Control c in casillasMarcadas)
                            {
                                Console.WriteLine(c.Name.ToString());
                            }
                        */
                            return;
                        }
                    // Si la casilla es roja y haces drop, vuelve a azul
                        pic_Box.BackColor = blue;
                    }
                // Anyadimos los eventos a cada uno de los pic_Box
                    pic_Box.DragEnter += new DragEventHandler(pic_Box_DragEnter);
                    pic_Box.DragLeave += new EventHandler(pic_Box_DragLeave);
                    pic_Box.DragDrop += new DragEventHandler(pic_Box_DragDrop);

                    pic_Box.Name = i + "" + u;
                    table_tablero.Controls.Add(pic_Box, i, u);
                }    
            }
        }

    // Pinta el pic_Box dependiendo de la posicion
        private void posicionBarco(PictureBox pic)
        {
        // Guardamos la posicion en la tabla en una variable
            TableLayoutPanelCellPosition posicionCelda = table_tablero.GetCellPosition(pic);
        // Si el eje x esta activado y no hay suficiente espacio hacia la derecha pintamos de rojo
        // Si el eje y esta activado y no hay suficiente espacio hacia abajo pintamos de rojo
           if((eje && posicionCelda.Column > 6) || (!eje && posicionCelda.Row > 6))
            {
                pic.BackColor = red;
                return;
            }
        // Comprobamos si hay barcos cerca, si los hay pintamos de rojo
           else if (tieneCasillasMarcadasAlLado(pic))
            {
                pic.BackColor = red;
                return;
            }
        // Si no, la posicion es correcta, pintamos de verde y la guardamos en casillas correctas
            for (int i = 0; i < 4; i++)
            {
                Control c = table_tablero.GetControlFromPosition(posicionCelda.Column, posicionCelda.Row);
                c.BackColor = green;
                casillasCorrectas.Add(c);

            // Dependiendo del eje seleccionado iteramos en funcion de columnas o filas
                if (eje) posicionCelda.Column++;
                else posicionCelda.Row++;
            }
        }

    // Comprueba si la casilla esta ya ocupada
        private bool estaMarcada(PictureBox pic)
        {
            Control c = pic;
            if (casillasMarcadas.IndexOf(c) != -1) return true;
            return false;
        }
        
    // Guardamos la posicion en casillasMarcadas 
        private void guardarCasillas(PictureBox pic)
        {
            TableLayoutPanelCellPosition posicionCelda = table_tablero.GetCellPosition(pic);
           
            for (int i = 0; i < 4; i++)
            {
                Control c = table_tablero.GetControlFromPosition(posicionCelda.Column, posicionCelda.Row);
                casillasMarcadas.Add(c);

            // Dependiendo del eje seleccionado iteramos en funcion de columnas o filas
                if (eje) posicionCelda.Column++;
                else posicionCelda.Row++;
            }
        }

        private bool tieneCasillasMarcadasAlLado(PictureBox pic)
        {
            TableLayoutPanelCellPosition posicionCelda = table_tablero.GetCellPosition(pic);

            for (int i = 0; i < 4; i++)
            {
                Control c = table_tablero.GetControlFromPosition(posicionCelda.Column, posicionCelda.Row);
                if (casillasMarcadas.IndexOf(c) != -1) return true;

            // Dependiendo del eje seleccionado iteramos en funcion de columnas o filas
                if (eje) posicionCelda.Column++;
                else posicionCelda.Row++;
            }
            return false;
        }

    // Cambia el eje
        private void butRotar_Click(object sender, EventArgs e)
        {
            if (eje)
            {
                eje = false;
                butRotar.Text = "Eje Y";
            }
            else
            {
                eje = true;
                butRotar.Text = "Eje X";
            }
        }

    // Eventos MouseDown de las imagenes de los 4 barcos diferentes
        private void pic_Carrier_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(pic_Carrier.BackgroundImage, DragDropEffects.Copy);
        }

        private void pic_Submarine_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(pic_Submarine.BackgroundImage, DragDropEffects.Copy);

        }

        private void pic_Destroyer_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(pic_Destroyer.BackgroundImage, DragDropEffects.Copy);

        }

        private void pic_Patrol_MouseDown(object sender, MouseEventArgs e)
        {
            DoDragDrop(pic_Patrol.BackgroundImage, DragDropEffects.Copy);

        }
        private void butSiguiente_Click(object sender, EventArgs e)
        {

        }
    }

}
