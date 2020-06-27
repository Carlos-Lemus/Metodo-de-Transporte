using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//los objetos de esta clase representan cada celda de la aplicacion
namespace MetodoDeTransporte
{
    class Datos
    {
        //atributos de la clase
        private int cantidad = 0;
        private double precio = 0; 
        private bool llena = false;
        //setters y getters de la clase
        public int Cantidad { set { this.cantidad = value; } get { return this.cantidad; } }
        public double Precio { set { this.precio = value; } get { return this.precio; } }
        public bool Llena { set { this.llena = value; } get { return this.llena; } }

        public Datos()
        {

        }

    }
}
