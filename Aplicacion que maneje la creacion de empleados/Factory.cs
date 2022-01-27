using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    class Factory
    {  
        
        public static IImplementacion Crearempleado(int emp)
        {
            if (emp==1)
            {
                return Gerencial.Instance();
            }
            else if (emp==2)
            {
                return new Administrativo();
            }
            else
            {
                return new Operativo();
            }
        }
    
    
    }
}
