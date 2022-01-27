using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    public abstract class Empleado
    {
        
        public string cedula { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email{get;set;}
        public string telefono { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public double precio { get; set; }
        public int hora { get; set; }
        public double salario { get; set; }

        public void sueldo()
        {
            salario = precio * hora;
        }
    }
}
