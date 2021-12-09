using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud
{
    public class Empleado
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public int Age { get; set; }
        public double Sueldo { get; set; }

        public Empleado() { }
        public Empleado(string indentificacion, string nombre, int edad, double sueldo)
        {
            this.Identificacion = indentificacion;
            this.Nombre = nombre;
            this.Age = edad;
            this.Sueldo = sueldo;
        }

        public string Edad()
        {
            if (Age >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "No es mayor de edad";
            }
        }

        public string pagar_impuestos()
        {
            if (Sueldo >= 1500)
            {
                return "Debe pagar impuestos";
            }
            else
            {
                return "No debe pagar impuestos";
            }
        }
    }
}
