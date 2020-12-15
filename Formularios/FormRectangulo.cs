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
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (txtBaseR.Text != String.Empty && txtAlturaR.Text != String.Empty)
            {
                try
                {
                    Rectangulo rectangulo = new Rectangulo();
                    rectangulo.BaseRectangulo = Convert.ToDouble(txtBaseR.Text);
                    rectangulo.AlturaRectangulo = Convert.ToDouble(txtAlturaR.Text);
                    rectangulo.CalcularAreaRectangulo();
                    rectangulo.VisualizarResultadoRectangulo();
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
