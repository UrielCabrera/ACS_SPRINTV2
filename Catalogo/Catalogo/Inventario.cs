using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Inventario
    {
        private ArrayList productosArray;
        private ArrayList imagenes;
        private Producto[] productos;
        private int totalProductos;
        private string[] productoString;
        public Inventario()
        {
            productosArray = new ArrayList();
            imagenes = new ArrayList();
            totalProductos = 0;
            
        }
        public void AgregarProducto(Producto articulo)
        {

            productosArray.Add(articulo);
            totalProductos = totalProductos + 1;
        }

        public void AgregarImagen(PictureBox pictureBox) {
            imagenes.Add(pictureBox);
        }

        public Producto[] Productos
        {
            get {
                productos = new Producto[totalProductos];
                for (int j=0;j<totalProductos;j++) {
                    productos[j] = (Producto)productosArray[j];   
                }

                return productos;
            }
        }

        public ArrayList Imagenes {
            get { return imagenes; }
        }

        public Producto GetProducto(int indice) 
        { 
            return (Producto)productosArray[indice]; 
        }

        public PictureBox GetImagen(int indice) {
            return (PictureBox)imagenes[indice];
        }

        public int TotalProductos {
            get { return totalProductos; }
        }

        public string[] ProductosToString() {
            productoString = new string[totalProductos];
            string[] cadena=new string[6];
            for (int i=0;i<totalProductos;i++) {                          
                productoString[i] =((Producto)productosArray[i]).ToString();
            }
            return productoString;
        }

    }
}
