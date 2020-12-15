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
   * Atributo de tipo double correspondiente al área
   */
    private double areaTriangulo;

    /*
    * Método de acceso a la base del triángulo
    */
    public double BaseTriangulo { get => baseTriangulo; set => baseTriangulo = value; }

    /*
    * Método de acceso a la altura del triángulo
    */
    public double AlturaTriangulo { get => alturaTriangulo; set => alturaTriangulo = value; }

    /*
    * Método de acceso al área del triángulo
    */
    public double AreaTriangulo { get => areaTriangulo; set => areaTriangulo = value; }

    /*
    * Método en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosTriangulo() {
        FormTriangulo formTriangulo = new FormTriangulo();
        formTriangulo.Show();
    }

    /*
    * Método encargado de calcular el área
    */
    public void CalcularAreaTriangulo() {
        AreaTriangulo = (BaseTriangulo * AlturaTriangulo)/2;
    }

    /*
    * Método en el que se envía un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoTriangulo() {
        MessageBox.Show("El área del triángulo es: " + AreaTriangulo);
    }

}