using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    class Menu
    {

        public static IImplementacion implementacion;
        

        public static List<IImplementacion> Crear_empleado = new List<IImplementacion>();
        public static List<IImplementacion> Crear_administrativo = new List<IImplementacion>();
        public static List<IImplementacion> Crear_operativo = new List<IImplementacion>();
        public static void listado()
        {
            foreach (IImplementacion data in Crear_empleado)
            {
                Console.WriteLine(data);
            }
        }
        public static void menu()
        {
            Console.WriteLine();
            Console.WriteLine("¿Que usted desea?");
            Console.WriteLine();
            Console.WriteLine("1- Agregar empleado");
            Console.WriteLine("2- Mostrar listado de empleados");
            Console.WriteLine("3- Cobrar");
            Console.WriteLine("4- Facturas");
            Console.WriteLine("5- Salir");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("¿Que tipo de empleado desea crear?");
                Console.WriteLine("1- Gerencial");
                Console.WriteLine("2- Administrativo");
                Console.WriteLine("3- Operativo");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    implementacion = Factory.Crearempleado(num);
                    
                    Crear_empleado.Add(implementacion);
                    menu();

                }
                else if (num == 2)
                {
                    implementacion = Factory.Crearempleado(num);
                    implementacion.crear();
                    Crear_administrativo.Add(implementacion);
                    menu();
                }
                else if (num == 3)
                {
                    implementacion = Factory.Crearempleado(num);
                    implementacion.crear();
                    Crear_operativo.Add(implementacion);
                    menu();
                }
                else
                {
                    menu();
                }


            }
            else if (n == 2)
            {
                Console.WriteLine("EMPLEADO GERENCIAL:");
                Gerencial.Mostrar();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("EMPLEADO ADMINISTRATIVO:");
                Administrativo.Mostrar();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("EMPLEADO OPERATIVO:");
                Operativo.Mostrar();
                Console.WriteLine("-------------------------------------------");
                menu();

            }
            else if (n == 3)
            {
                Gerencial.cobro();
                Administrativo.cobro();
                Operativo.cobro();

            }
            else if (n == 4)
            {
                Console.WriteLine("Recibo de pago del Gerente:");
                Gerencial.Mostrar();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Recibo de pago del Administrativo:");
                Administrativo.Mostrar();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Recibo de pago del Operativo");
                Operativo.Mostrar();
                Console.WriteLine("-------------------------------------------");
                
                menu();
            }
            else if (n==5)
            {
                Environment.Exit(1);
            }
            else
            {
                menu();
            }
        }
        
    }
}
   
        
    

    
