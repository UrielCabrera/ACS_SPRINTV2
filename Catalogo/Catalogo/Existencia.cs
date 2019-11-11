using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Existencia
    {
        private int piezasInventario;
        private string disponible;
        public Existencia(int existencias)
        {
            this.piezasInventario = existencias;
            fijaDisponible(existencias);
        }

        public int PiezasInventario
        {
            get { return piezasInventario; }
            set
            {
                piezasInventario =value;
            }
        }

        public string Disponible
        {
            get {return disponible; }
        }

        private void fijaDisponible(int numero) {
            if (numero == 0)
            {
                disponible = "\nARTICULO NO  DISPONIBLE ";
            }
            else
            {
                disponible = "";
            }
        }


    }
}
