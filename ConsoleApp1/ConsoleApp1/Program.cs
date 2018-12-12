using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta aplicación sirve para probar librerias!!");
            Console.ReadKey();

            Console.Write("Enter the path of the dll file: ");
            AppDomain.CurrentDomain.Load(assemble(Console.ReadLine()).GetName());

            //Codigo para probar las funciones de una libreria
        }

        static Assembly assemble(string path) {
            Assembly a = Assembly.LoadFrom(path);
            return a;
        }
    }
}
