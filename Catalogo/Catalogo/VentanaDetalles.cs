using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Catalogo
{
    public partial class VentanaDetalles : Form{
        private int idImagen;
        private Inventario inventarioTemporal;
        public VentanaDetalles()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e){ labelMaximo.Text=""; }
        internal void FijarImagen(Image picturebox,int idImagen,int noMaxPiezas) 
        {
            pictureBox1.Image=picturebox;
            this.idImagen = idImagen;
            numericUpDown1.Maximum = noMaxPiezas;
        }
        internal void FijarLabel(String lbl,Inventario inventarioTemporal) 
        { 
            label1.Text = lbl;
            this.inventarioTemporal = inventarioTemporal;
        }
        private void VentanaDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {          
        }

        private void Button1_Click(object sender, EventArgs e){
            StreamWriter agregar = File.AppendText("Venta.txt");
            agregar.WriteLine(idImagen + "," + numericUpDown1.Value);
            agregar.Close();
            MessageBox.Show("Articulo añadido al carrito");
            modificarInventario();
        }

        private void numericUpDown1_MouseUp(object sender, MouseEventArgs e)
        {
            if (numericUpDown1.Value == numericUpDown1.Maximum)
            {
                
                labelMaximo.Text = "Limite de piezas disponible";
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e) { }
        private void numericUpDown1_KeyUp(object sender, KeyEventArgs e){}

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e){}

        private void numericUpDown1_Scroll(object sender, ScrollEventArgs e){}

        private void numericUpDown1_Enter(object sender, EventArgs e){}

        private void VentanaDetalles_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void modificarInventario() {
            string[] lista;
            int piezasInv;
            int numeric = Convert.ToInt32(numericUpDown1.Value);
            Producto[] productos = inventarioTemporal.Productos;

            for (int j = 0; j < inventarioTemporal.TotalProductos; j++){

                
                if (inventarioTemporal.GetProducto(j).Id == idImagen){
                    piezasInv = inventarioTemporal.GetProducto(j).Existencias.PiezasInventario; 
                    inventarioTemporal.GetProducto(j).Existencias.PiezasInventario =piezasInv-numeric;               
                }
             }

            lista = inventarioTemporal.ProductosToString();
            using (StreamWriter escribir = new StreamWriter(@"E:\DescargasPepita\CalidadSoftware_Alejandra\ProyectoPlumas\Catalogo\Catalogo\bin\Debug\RespaldoRegistro.txt")) {
                foreach (string cad in lista)
                {
                    escribir.WriteLine(cad);
                }

            }
                
        }

 
    }
}
