using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud
{
    public class Crud
    {
        List<Empleado> dataset = new List<Empleado>();
        string nombre, identificacion;
        int edad;
        double sueldo;

        public void CrearEmpleado()
        {
            Console.WriteLine("----- Crear empleado -----");
            Console.WriteLine("\nIngrese identificación: ");
            
            identificacion = Console.ReadLine();

            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese sueldo: ");
            sueldo = double.Parse(Console.ReadLine());

            dataset.Add(new Empleado(identificacion, nombre, edad, sueldo));

            Console.WriteLine("\nDatos guardados con exito");
        }

        private bool ListaVacia()
        {
            if (dataset.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Lista()
        {
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine($"Total de Registros de empleados: {dataset.Count}");
                Console.WriteLine("----- Lista -----");

                foreach (Empleado item in dataset)
                {
                    Imprimir(item);
                }
            }
            Console.WriteLine("\n");
        }

        private void Imprimir(Empleado dato)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("| Identificacion: {0} | Nombre: {1} | Edad: {2} | Sueldo: {3} |", dato.Identificacion, dato.Nombre, dato.Age, dato.Sueldo);
            Console.Write(">> {0} >> {1}", dato.Edad(), dato.pagar_impuestos());
        }

        public void Eliminar()
        {
            string buscar;

            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato en la lista");
            }
            else
            {
                Console.WriteLine("Ingrese identificación: ");
                buscar = Console.ReadLine();

                foreach (var item in dataset)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("| Identificacion: {0} | Nombre: {1} | Edad: {2} | Sueldo: {3} |", item.Identificacion, item.Nombre, item.Age, item.Sueldo);
                        Console.Write(">> {0} >> {1}", item.Edad(), item.pagar_impuestos());
                        dataset.Remove(item);
                        Console.WriteLine("El dato ha sido eliminado");
                    }
                    else
                    {
                        Console.WriteLine("No se encontró la identificación del empleado");
                    }
                }
            }
        }

        public void Modificar()
        {
            string buscar;
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encuentra ningun dato");
            }
            else
            {
                Empleado ap = new Empleado();
                Console.Write("Ingrese identificación:");
                buscar = Console.ReadLine();
                foreach (Empleado item in dataset)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("| Identificacion: {0} | Nombre: {1} | Edad: {2} | Sueldo: {3} |", item.Identificacion, item.Nombre, item.Age, item.Sueldo);
                        Console.Write(">> {0} >> {1}", item.Edad(), item.pagar_impuestos());
                        Console.WriteLine("---------------------------\n\n");
                        Console.Write("Ingrese identificación: ");
                        ap.Identificacion = Console.ReadLine();
                        item.Identificacion = ap.Identificacion;
                        Console.Write("Ingrese nombre: ");
                        ap.Nombre = Console.ReadLine();
                        item.Nombre = ap.Nombre;
                        Console.Write("Ingrese edad: ");
                        ap.Age = int.Parse(Console.ReadLine());
                        item.Age = ap.Age;
                        Console.Write("Ingrese sueldo: ");
                        ap.Sueldo = double.Parse(Console.ReadLine());
                        item.Sueldo = ap.Sueldo;
                        ap.pagar_impuestos();
                        Console.WriteLine("\nLos datos han sido modificados de forma exitosa");
                    }
                }
            }
        }

        public void Buscar()
        {
            string buscar;
            if (ListaVacia() == true)
            {
                Console.WriteLine("No se encontraron datos");
            }
            else
            {
                Console.Write("Ingrese identificacion para buscar: ");
                buscar = Console.ReadLine();
                foreach (Empleado item in dataset)
                {
                    if (buscar == item.Identificacion)
                    {
                        Console.WriteLine("| Identificacion: {0} | Nombre: {1} | Edad: {2} | Sueldo: {3} |", item.Identificacion, item.Nombre, item.Age, item.Sueldo);
                        Console.Write(">> {0} >> {1}", item.Edad(), item.pagar_impuestos());
                    }
                    else
                    {
                        Console.WriteLine("No se encontró el empleado");
                    }
                }
            }
        }
    }
}
