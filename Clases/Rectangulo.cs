using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigurasGeometricas.Formularios;
using System.Windows.Forms;

public class Rectangulo : Figura {

    public Rectangulo() {
    }

    /*
    * Atributo de tipo double que corresponde a la base del rectángulo
    */
    private double baseRectangulo;
   /*
   * Atributo de tipo double que corresponde a la altura del rectángulo
   */
    private double alturaRectangulo;
   /*
   * Atributo de tipo double que corresponde al área del rectángulo
   */
    private double areaRectangulo;

   /*
   * Método de acceso a la base del rectángulo
   */
    public double BaseRectangulo { get => baseRectangulo; set => baseRectangulo = value; }
    
   /*
   * Método de acceso a la altura del rectángulo
   */
    public double AlturaRectangulo { get => alturaRectangulo; set => alturaRectangulo = value; }
   
    /*
   * Método de acceso al área del rectángulo
   */
    public double AreaRectangulo { get => areaRectangulo; set => areaRectangulo = value; }

    /*
    * Método en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosRectangulo() {
        FormRectangulo formRectangulo = new FormRectangulo();
        formRectangulo.Show();
    }

    /*
    * Método encargado de calcular el área
    */
    public void CalcularAreaRectangulo() {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * Método en el que se envía un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoRectangulo() {
        MessageBox.Show("El área del rectángulo es: " + AreaRectangulo);
    }

}