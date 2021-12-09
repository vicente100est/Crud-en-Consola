using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud
{
    public class Menu : Crud
    {
        string opciones = "";

        public void iniciar()
        {
            do
            {
                cabezera();
            }
            while (opciones != "0");
        }

        private void cabezera()
        {
            Console.WriteLine("---- Control de Empleados ----\n");
            Console.WriteLine("---- MENU PRINCIPAL ----\n");
            Console.WriteLine("1 [Crear registro]       | 3 [Eliminar Empleado]");
            Console.WriteLine("2 [Lista de Empleados]   | 4 [Modificar Empleado]");
            Console.WriteLine("0 [Salir]                | 5 [Buscar Empleado]");
            Console.WriteLine("\nSeleccione una opción");
            opciones = Console.ReadLine();
            Seleccion_Menu(opciones);
        }

        private void Seleccion_Menu(string op)
        {
            if (op == "")
                return;
            switch (op)
            {
                case "1":
                    Console.Clear();
                    CrearEmpleado();
                    Retornar_Menu();
                    Console.ReadKey();
                    break;
                case "2":
                    Console.Clear();
                    Lista();
                    Retornar_Menu();
                    Console.ReadKey();
                    break;
                case "3":
                    Console.Clear();
                    Eliminar();
                    Retornar_Menu();
                    Console.ReadKey();
                    break;
                case "4":
                    Console.Clear();
                    Modificar();
                    Retornar_Menu();
                    Console.ReadKey();
                    break;
                case "5":
                    Console.Clear();
                    Buscar();
                    Retornar_Menu();
                    Console.ReadKey();
                    break;
                case "r":
                    Console.Clear();
                    cabezera();
                    Console.ReadKey();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Seleccion invalida");
                    break;
            }
        }

        private void Retornar_Menu()
        {
            string op;
            Console.WriteLine("Presione r para retornar al menu principal");
            op = Console.ReadLine();
            Seleccion_Menu(op);
        }
    }
}
