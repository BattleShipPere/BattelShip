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
        List<TableLayoutPanelCellPosition> posicionCelda = new List<TableLayoutPanelCellPosition>();

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

        public List<TableLayoutPanelCellPosition> getPosicionCelda()
        {
            return this.posicionCelda;
        }
        public void setPosicionCelda(List<TableLayoutPanelCellPosition> posicion)
        {
            this.posicionCelda = posicion;
        }

    }
}
