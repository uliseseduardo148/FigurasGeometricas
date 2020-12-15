using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Figura {

    public Figura() {
    }

    /*
    * Atributo de tipo string correspondiente al nombre de la figura
    */
    private String nombreFigura;

    /*
    * Método de acceso al nombre de la figura
    */
    public string NombreFigura { get => nombreFigura; set => nombreFigura = value; }
}