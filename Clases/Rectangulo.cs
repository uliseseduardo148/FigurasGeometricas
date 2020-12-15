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
    * Atributo de tipo double que corresponde a la base del rect�ngulo
    */
    private double baseRectangulo;
   /*
   * Atributo de tipo double que corresponde a la altura del rect�ngulo
   */
    private double alturaRectangulo;
   /*
   * Atributo de tipo double que corresponde al �rea del rect�ngulo
   */
    private double areaRectangulo;

   /*
   * M�todo de acceso a la base del rect�ngulo
   */
    public double BaseRectangulo { get => baseRectangulo; set => baseRectangulo = value; }
    
   /*
   * M�todo de acceso a la altura del rect�ngulo
   */
    public double AlturaRectangulo { get => alturaRectangulo; set => alturaRectangulo = value; }
   
    /*
   * M�todo de acceso al �rea del rect�ngulo
   */
    public double AreaRectangulo { get => areaRectangulo; set => areaRectangulo = value; }

    /*
    * M�todo en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosRectangulo() {
        FormRectangulo formRectangulo = new FormRectangulo();
        formRectangulo.Show();
    }

    /*
    * M�todo encargado de calcular el �rea
    */
    public void CalcularAreaRectangulo() {
        AreaRectangulo = BaseRectangulo * AlturaRectangulo;
    }

    /*
    * M�todo en el que se env�a un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoRectangulo() {
        MessageBox.Show("El �rea del rect�ngulo es: " + AreaRectangulo);
    }

}