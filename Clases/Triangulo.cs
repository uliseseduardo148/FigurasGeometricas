using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigurasGeometricas.Formularios;
using System.Windows.Forms;


public class Triangulo : Figura {

    public Triangulo() {

    }

   /*
   * Atributo de tipo double correspondiente a la base 
   */
    private double baseTriangulo;

   /*
   * Atributo de tipo double correspondiente a la altura
   */
    private double alturaTriangulo;

   /*
   * Atributo de tipo double correspondiente al �rea
   */
    private double areaTriangulo;

    /*
    * M�todo de acceso a la base del tri�ngulo
    */
    public double BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }

    /*
    * M�todo de acceso a la altura del tri�ngulo
    */
    public double AlturaTriangulo { get => alturaTriangulo; set => alturaTriangulo = value; }

    /*
    * M�todo de acceso al �rea del tri�ngulo
    */
    public double AreaTriangulo { get => areaTriangulo; set => areaTriangulo = value; }

    /*
    * M�todo en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosTriangulo() {
        FormTriangulo formTriangulo = new FormTriangulo();
        formTriangulo.Show();
    }

    /*
    * M�todo encargado de calcular el �rea
    */
    public void CalcularAreaTriangulo() {
        AreaTriangulo = (BaseTriangulo * AlturaTriangulo)/2;
    }

    /*
    * M�todo en el que se env�a un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoTriangulo() {
        MessageBox.Show("El �rea del tri�ngulo es: " + AreaTriangulo);
    }

}