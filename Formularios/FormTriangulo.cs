using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas.Formularios
{
    public partial class FormTriangulo : Form
    {
        public FormTriangulo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBaseT.Text != String.Empty && txtAlturaT.Text != String.Empty)
            {
                try
                {
                    Triangulo triangulo = new Triangulo();
                    triangulo.BaseTriangulo = Convert.ToDouble(txtBaseT.Text);
                    triangulo.AlturaTriangulo = Convert.ToDouble(txtAlturaT.Text);
                    triangulo.CalcularAreaTriangulo();
                    triangulo.VisualizarResultadoTriangulo();
                }
                catch {
                    MessageBox.Show("Los datos no son los esperados");
                }
            }
            else
            {
                MessageBox.Show("Hay campos vacíos");
            }
        }
    }
}
