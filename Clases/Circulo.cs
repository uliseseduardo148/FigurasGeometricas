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
     * Atributo de tipo doible que hace referencia al �rea del circulo
     */
    private double areaCirculo;

    /*
    * M�todo de acceso al radio del c�rculo
    */
    public double RadioCirculo { get => radioCirculo; set => radioCirculo = value; }

    /*
    * M�todo de acceso al �rea del c�rculo
    */
    public double AreaCirculo { get => areaCirculo; set => areaCirculo = value; }

    /*
    * M�todo en el que se instancia la ventana que permite al usuario la captura de datos
    */
    public void PedirDatosCirculo() {
        FormCirculo formCirculo = new FormCirculo();
        formCirculo.Show();
    }

    /*
    * M�todo encargado de calcular el �rea del c�rculo
    */
    public void CalcularAreaCirculo() {
        AreaCirculo = Convert.ToDouble(Math.PI * Math.Pow(RadioCirculo, 2)) ;
    }

    /*
    * M�todo en el que se env�a un mensaje al usuario con el resultado obtenido anteriormente
    */
    public void VisualizarResultadoCirculo() {
        MessageBox.Show("El �rea del c�rculo es: " + AreaCirculo);
    }

}