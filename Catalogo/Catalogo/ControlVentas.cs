using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public class ControlVentas
    {
        private Carrito carrito;
        ControlInventario ctrlInventarioCarrito = new ControlInventario();

        private string leerVentas;
        private string[] filas;
        public ControlVentas() {
            carrito = new Carrito();
            leerVentas = File.ReadAllText("Venta.txt");
            ctrlInventarioCarrito.CargarInventario(1);
            if (leerVentas.Length!=0) {
                filas = leerVentas.Split(new string[] { System.Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            }            
        }

        //Carga las ventas al carrito
        internal void CargarVentasDeArchivo()
        {
            if (leerVentas.Length>0) {

                    if (carrito.NumeroArticulos == 0)
                    {
                        CrearVenta();

                    }

                
            }
             //termina else      
           
        }
        private void CrearVenta()
        {
            int idImagen;
            int numPiezas;
            string[] columnas;
            foreach (string linea in filas)
            {
                columnas = linea.Split(',');
                idImagen = Convert.ToInt32(columnas[0]);
                numPiezas = Convert.ToInt32(columnas[1]);
                carrito.AgregarVenta(new Venta(ctrlInventarioCarrito.Inventario.GetProducto(idImagen), numPiezas));
            }
        }
        internal Carrito Carrito {
            get { return carrito; }
        }




    }
}
