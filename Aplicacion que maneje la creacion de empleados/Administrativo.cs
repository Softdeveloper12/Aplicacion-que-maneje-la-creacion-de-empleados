using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    class Administrativo:Empleado,IImplementacion
    {

        public static Random al = new Random();
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
            Console.WriteLine("Salario:", salario);
            Console.WriteLine("Se ha creado un empleado administrativo");
        }
        public override string ToString()
        {
            string empleado = $"Codigo:{codigo}\nCedula:{cedula}\nNomre:{nombre}\nApellido:{apellido}\nEmail:{email}\nTelefono:{telefono}\nDepartamento:{departamento}\nCargo:{cargo}\nPrecio:{precio}\nHoras trabajadas:{hora}\nSalario neto:{salario}";
            return empleado;
        }
        
        public static void Mostrar()
        {


            foreach (Administrativo adm in Menu.Crear_administrativo)
            {
                Console.WriteLine($"Codigo:{adm.departamento.Substring(0,3)}\nCedula:{adm.cedula}\nNomre:{adm.nombre}\nApellido:{adm.apellido}\nEmail:{adm.email}\nTelefono:{adm.telefono}\nDepartamento:{adm.departamento}\nCargo:{adm.cargo}\nPrecio:{adm.precio}\nHoras trabajadas:{adm.hora}\nSalario neto:{adm.salario}");
                
            }
            

        }
        public static void cobro()
        {
            foreach (Administrativo ad in Menu.Crear_empleado)
            {
                double bono = ad.salario + (ad.salario * 0.5);
                Console.Write($"Bono:{bono}");
            }

        }
    }
}
