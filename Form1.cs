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
    // Variables row and column
        int totalCols;
        int totalRows;
    //Colores
        public static Color red = Color.FromArgb(252, 92, 101);
        public static Color green = Color.FromArgb(32, 191, 107);
        public static Color blue = Color.FromArgb(116, 185, 255);
        // List<>
        List<Control> casillasCorrectas = new List<Control>();  // Ubicaciones no guardadas
        List<Control> casillasMarcadas = new List<Control>();  // Ubicaciones de Barcos.
        List<Object> barcosColocados = new List<Object>();
    // True == Eje X ; False == Eje Y
        bool eje = true;
    // Barcos sin posicion
        Barcos portaviones = new Barcos(4, "portaviones");
        int countPort = 1;

        Barcos submarino1 = new Barcos(3, "submarino1");
        Barcos submarino2 = new Barcos(3, "submarino2");
        int countSub = 2;

        Barcos destructor1 = new Barcos(2, "destructor1");
        Barcos destructor2 = new Barcos(2, "destructor2");
        Barcos destructor3 = new Barcos(2, "destructor3");
        int countDes = 3;

        Barcos patrullero1 = new Barcos(1, "patrullero1");
        Barcos patrullero2 = new Barcos(1, "patrullero2");
        Barcos patrullero3 = new Barcos(1, "patrullero3");
        Barcos patrullero4 = new Barcos(1, "patrullero4");
        int countPatr = 4;

        Barcos barcoSeleccionado;
    // Constructor form1
        public Form1()
        {
            InitializeComponent();

            table_tablero.BackColor = blue;

            // barcoSeleccionado = destructor1;

            table_tablero.BackColor = Color.Transparent;
            totalCols = table_tablero.ColumnCount;
            totalRows = table_tablero.RowCount;

            CrearPicBoxs();
        }
    //Crea todos los picture box en el table_tablero y sus eventos Drag & Drop
        private void CrearPicBoxs()
        {

            for (int i = 0; i < totalCols; i++)
            {

                for (int u = 0; u < totalRows; u++)
                {

                    PictureBox pic_Box = new PictureBox();
                    pic_Box.BackColor = blue;
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
                            actualizarLabels(barcoSeleccionado);
                            for(int k = casillasMarcadas.Count - 1; k > casillasMarcadas.Count - barcoSeleccionado.getLength() - 1; k--)
                            {
                                barcoSeleccionado.getPosicionCelda().Add(casillasMarcadas[k].Name);
                            }
                            barcosColocados.Add(barcoSeleccionado);
                            if (barcosColocados.Count == 10)
                            {
                                butContinue.Enabled = true;
                                butContinue.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Continue;
                            }

                            // Muestra casillas marcadas al hacer drop valido
                            /* foreach(String c in barcoSeleccionado.getPosicionCelda())
                            {
                                Console.WriteLine(c);
                            } */
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
            // Variable para controlar
            int distancia = totalCols - barcoSeleccionado.getLength();
        // Si el eje x esta activado y no hay suficiente espacio hacia la derecha pintamos de rojo
        // Si el eje y esta activado y no hay suficiente espacio hacia abajo pintamos de rojo
           if((eje && posicionCelda.Column > distancia) || (!eje && posicionCelda.Row > distancia))
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
            for (int i = 0; i < barcoSeleccionado.getLength(); i++)
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
           
            for (int i = 0; i < barcoSeleccionado.getLength(); i++)
            {
                Control c = table_tablero.GetControlFromPosition(posicionCelda.Column, posicionCelda.Row);
                casillasMarcadas.Add(c);

            // Dependiendo del eje seleccionado iteramos en funcion de columnas o filas
                if (eje) posicionCelda.Column++;
                else posicionCelda.Row++;
            }
        }
    // Método tieneCasisllasMarcadasAlLado
        private bool tieneCasillasMarcadasAlLado(PictureBox pic)
        {
            TableLayoutPanelCellPosition posicionCelda = table_tablero.GetCellPosition(pic);

            for (int i = 0; i < barcoSeleccionado.getLength(); i++)
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
      
    // Eventos MouseDown de las imagenes de los 4 barcos diferentes
        private void pic_Carrier_MouseDown(object sender, MouseEventArgs e)
        {
            if (!barcosColocados.Contains(portaviones)) barcoSeleccionado = portaviones;
            else
            {
                pic_Carrier.Enabled = false;
                return;
            }
            DoDragDrop(pic_Carrier.BackgroundImage, DragDropEffects.Copy);
        }

        private void pic_Submarine_MouseDown(object sender, MouseEventArgs e)
        {
            if (!barcosColocados.Contains(submarino1)) barcoSeleccionado = submarino1;
            else if (!barcosColocados.Contains(submarino2)) barcoSeleccionado = submarino2;
            else
            {
                pic_Submarine.Enabled = false;
                return;
            }
            DoDragDrop(pic_Submarine.BackgroundImage, DragDropEffects.Copy);
        }

        private void pic_Destroyer_MouseDown(object sender, MouseEventArgs e)
        {

            if (!barcosColocados.Contains(destructor1)) barcoSeleccionado = destructor1;
            else if (!barcosColocados.Contains(destructor2)) barcoSeleccionado = destructor2;
            else if (!barcosColocados.Contains(destructor3)) barcoSeleccionado = destructor3;
            else
            {
                pic_Destroyer.Enabled = false;
                return;
            }
            DoDragDrop(pic_Destroyer.BackgroundImage, DragDropEffects.Copy);
        }

        private void pic_Patrol_MouseDown(object sender, MouseEventArgs e)
        {

            if (!barcosColocados.Contains(patrullero1)) barcoSeleccionado = patrullero1;
            else if (!barcosColocados.Contains(patrullero2)) barcoSeleccionado = patrullero2;
            else if (!barcosColocados.Contains(patrullero3)) barcoSeleccionado = patrullero3;
            else if (!barcosColocados.Contains(patrullero4)) barcoSeleccionado = patrullero4;
            else
            {
                pic_Patrol.Enabled = false;
                return;
            }
            DoDragDrop(pic_Patrol.BackgroundImage, DragDropEffects.Copy);
        }

        private void Button_Rotar_Click(object sender, EventArgs e)
        {
            if (eje)
            {
                eje = false;
                Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_Y_Selec;
            }
            else
            {
                eje = true;
                Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_X_Selec;
            }
        }

        private void pic_Submarine_Click(object sender, EventArgs e)
        {
            //
        }

        private void actualizarLabels(Barcos b)
        {
            if (b == portaviones)
            {
                countPort--;
                labPortaviones.Text = "x " + countPort;
                labPortaviones.ForeColor = red;
            }
            else if (b == submarino1 || b == submarino2)
            {
                countSub--;
                labSubmarino.Text = "x " + countSub;
                if (countSub == 0) labSubmarino.ForeColor = red;
            }
            else if (b == destructor1 || b == destructor2 || b == destructor3)
            {
                countDes--;
                labDestructor.Text = "x " + countDes;
                if (countDes == 0) labDestructor.ForeColor = red;
            }
            else if (b == patrullero4 || b == patrullero3 || b == patrullero2 || b == patrullero1)
            {
                countPatr--;
                labPatrullero.Text = "x " + countPatr;
                if (countPatr == 0) labPatrullero.ForeColor = red;
            }
            
        }

        private void butContinue_MouseHover(object sender, EventArgs e)
        {
            butContinue.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Continue_Selec;
        }

        private void butContinue_MouseLeave(object sender, EventArgs e)
        {
            butContinue.BackgroundImage = global::BattelShip.Properties.Resources.Boton_Continue;
        }

        private void Button_Rotar_MouseHover(object sender, EventArgs e)
        {
            if (eje) Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_X_Selec;
            else Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_Y_Selec;
        }

        private void Button_Rotar_MouseLeave(object sender, EventArgs e)
        {
            if (eje) Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_X;
            else Button_Rotar.BackgroundImage = global::BattelShip.Properties.Resources.Eje_Y;
        }

        private void butContinue_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3(barcosColocados);
            //form3.Show();
            FormLoad1 formLoad1 = new FormLoad1(barcosColocados);
            formLoad1.Show();
            Hide();
        }
    }

}
