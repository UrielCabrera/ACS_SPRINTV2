using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Catalogo
{
    public partial class Portada : Form
    {
        public Portada()
        {
            InitializeComponent();
        }

        private void lblInformacion1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            ControlInventario control1 = new ControlInventario();
            VentanaCategoria catalogo = new VentanaCategoria(control1);
            catalogo.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Portada_Load(object sender, EventArgs e)
        {

        }
    }
}
