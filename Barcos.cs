using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattelShip
{
    class Barcos
    {

        int length;
        int cantidad;
        string nombre;

        public Barcos(int t, int p, string n)
        {
            this.length = t;
            this.cantidad = p;
            this.nombre = n;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getCantidad()
        {
            return this.cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public String getNombre()
        {
            return this.nombre;
        }

    }
}
