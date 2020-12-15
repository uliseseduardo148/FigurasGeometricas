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
    public partial class FormCirculo : Form
    {
        public FormCirculo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtRadio.Text != String.Empty)
            {
                try
                {
                    Circulo circulo = new Circulo();
                    circulo.RadioCirculo = Convert.ToDouble(txtRadio.Text);
                    circulo.CalcularAreaCirculo();
                    circulo.VisualizarResultadoCirculo();
                }
                catch
                {
                    MessageBox.Show("Los datos no son los esperados");
                }
            }
            else {
                MessageBox.Show("El campo no puede estar vacío");
            }
        }
    }
}
