using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnTriangulo_Click(object sender, EventArgs e)
        {
            new Triangulo().PedirDatosTriangulo();
            this.Hide();
        }

        private void BtnRectangulo_Click(object sender, EventArgs e)
        {
            new Rectangulo().PedirDatosRectangulo();
            this.Hide();
        }

        private void BtnCirculo_Click(object sender, EventArgs e)
        {
            new Circulo().PedirDatosCirculo();
            this.Hide();
        }
    }
}
