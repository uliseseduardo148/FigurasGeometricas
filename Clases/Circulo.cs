using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FigurasGeometricas.Formularios;
using System.Windows.Forms;

public class Circulo : Figura {

    public Circulo() {
    }

    /*
     * Atributo de tipo doible que hace referencia al radio del circulo
     */
    private double radioCirculo;
    /*
     * Atributo de tipo doible que hace referencia al área del circulo
     */
    private double areaCirculo;

    /*
    * Método de acceso al radio del círculo
    */
    public double RadioCirculo { get => radioCirculo; set => radioCirculo = value; }

    /*
    * Método de acceso al área del círculo
    */
    public double AreaCirculo { get => areaCirculo; set => areaCirculo = value; }

    /*
    * Método en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosCirculo() {
        FormCirculo formCirculo = new FormCirculo();
        formCirculo.Show();
    }

    /*
    * Método encargado de calcular el área del círculo
    */
    public void CalcularAreaCirculo() {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2)) ;
    }

    /*
    * Método en el que se envía un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoCirculo() {
        MessageBox.Show("El área del círculo es: " + AreaCirculo);
    }

}