using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BattelShip
{
    class Barcos
    {
        int length;
        string nombre;
        List<String> posicionCelda = new List<String>();

        public Barcos(int len, string nom)
        {
            this.length = len;
            this.nombre = nom;
        }

        public int getLength()
        {
            return this.length;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public List<String> getPosicionCelda()
        {
            return this.posicionCelda;
        }
        public void setPosicionCelda(List<String> posicion)
        {
            this.posicionCelda = posicion;
        }

    }
}
