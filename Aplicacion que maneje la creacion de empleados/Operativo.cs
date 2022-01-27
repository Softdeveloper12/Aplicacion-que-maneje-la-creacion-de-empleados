using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicacion_que_maneje_la_creacion_de_empleados
{
    class Operativo:Empleado,IImplementacion
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
            Console.WriteLine("Se ha creado un empleado operativo");
        }
        public override string ToString()
        {
            string empleado = $"Codigo:{codigo}\nCedula:{cedula}\nNomre:{nombre}\nApellido:{apellido}\nEmail:{email}\nTelefono:{telefono}\nDepartamento:{departamento}\nCargo:{cargo}\nPrecio:{precio}\nHoras trabajadas:{hora}\nSalario neto:{salario}";
            return empleado;
        }
        public static void Mostrar()
        {


            foreach (Operativo op in Menu.Crear_operativo)
            {
                Console.WriteLine($"Codigo:{op.departamento.Substring(0, 3)}\nCedula:{op.cedula}\nNomre:{op.nombre}\nApellido:{op.apellido}\nEmail:{op.email}\nTelefono:{op.telefono}\nDepartamento:{op.departamento}\nCargo:{op.cargo}\nPrecio:{op.precio}\nHoras trabajadas:{op.hora}\nSalario neto:{op.salario}");

            }
            

        }
        public static void cobro()
        {
            foreach (Operativo opp in Menu.Crear_empleado)
            {
                double bono = opp.salario + (opp.salario * 0.5);
                Console.Write($"Bono:{bono}");
            }

        }
    }
}
