using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    class Producto
    {
        private int id;
        private Descripcion descripcion;
        private Existencia existencia;
        private string rutaImagen;
        //private PictureBox picture;
        private Image imagen;


        public Producto(string nombre, double precio, int categoria, string material, int numeroExistencias, int id)
        {
            descripcion = new Descripcion(nombre, precio, categoria, material);
            existencia = new Existencia(numeroExistencias);
            this.id = id;
        }
        public int Id {
            get { return id; }
             
        }

        public string GetNombrePrecioDispo()
        {
            //MessageBox.Show("Producto existencia:"+existencia.Disponible);
            string nombrePrecioDispo = descripcion.GetNombrePrecio() + existencia.Disponible;
            return nombrePrecioDispo;
        }

        public Descripcion Descripcion
        {
            get { return descripcion; }
        }

        public Existencia Existencias
        {
            get { return existencia; }
        }

        public void SetImagen(string cadena)
        {
            //MessageBox.Show("Producto.setImagen");
            imagen = Image.FromFile("E:\\DescargasPepita\\CalidadSoftware_Alejandra\\ProyectoPlumas\\Catalogo\\Catalogo\\IMAGENES\\"+cadena);
        }
        public Image Imagen
        {
            get { return imagen; }
        }
        public string RutaImagen {
            get { return rutaImagen; }
        }

        public override string ToString() {
            string[] array = new string[6];
            string cadena;
            array[0] = descripcion.Nombre;
            array[1] = descripcion.Precio.ToString();
            array[2] = descripcion.GetIntCategoria().ToString();
            array[3] = descripcion.GetMaterial();
            array[4] = existencia.PiezasInventario.ToString();
            array[5] = id.ToString();
            cadena = array[0] + "," + array[1] + "," + array[2] + "," + array[3] + "," + array[4] + "," + array[5];
            return cadena;
        }

    }
}
