using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    public class Gerencial:Empleado,IImplementacion
    {
        public static Random al = new Random();
       
        private static Gerencial instance = null;
        private Gerencial() 
        {
            crear();
        }
        public static Gerencial Instance()
        {
            
           if (instance == null)
            {
;             instance = new Gerencial();
             }
             return instance;
            
        }
        public void crear()
        {
            codigo = al.Next(1000, 10000);
            Console.WriteLine("\nIngrese su cedula:");
            cedula = Console.ReadLine();
            Console.WriteLine("\nIngrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("\nIngrese el apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("\nIngrese el Email:");
            email = Console.ReadLine();
            Console.WriteLine("\nIngrese el Telefono:");
            telefono = Console.ReadLine();
            Console.WriteLine("\nIngrese el Departamento:");
            departamento = Console.ReadLine();
            Console.WriteLine("\nIngrese el Cargo:");
            cargo = Console.ReadLine();
            Console.WriteLine("\nIngrese el precio por hora:");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("\nIngrese la cantidad de horas trabajadas:");
            hora = int.Parse(Console.ReadLine());
            salario = precio * hora;
            Console.WriteLine($"Sueldo neto:{salario}");
            Console.WriteLine("Se ha creado un empleado gerente");



        }
        
        
        public static void Mostrar()
        {
            foreach (Gerencial gerencial in Menu.Crear_empleado)
            {
                Console.WriteLine($"Codigo:{gerencial.departamento.Substring(0,3)}{gerencial.codigo}\nCedula:{gerencial.cedula}\nNomre:{gerencial.nombre}\nApellido:{gerencial.apellido}\nEmail:{gerencial.email}\nTelefono:{gerencial.telefono}\nDepartamento:{gerencial.departamento}\nCargo:{gerencial.cargo}\nPrecio:{gerencial.precio}\nHoras trabajadas:{gerencial.hora}\nSalario neto:{gerencial.salario}");

            }
        }
        public static void cobro()
        {
            foreach(Gerencial ger in Menu.Crear_empleado)
            {
                double bono = ger.salario + (ger.salario * 0.5);
                Console.Write($"Bono:{bono}");
            }
            
        }
    }
}
