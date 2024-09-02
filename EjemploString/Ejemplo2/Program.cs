using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre  = "Pedro";
            nombre = "Hola señor " + nombre;
            int cantC = nombre.Length;

            nombre = nombre.Replace("Hola" , "Chau");
            
            
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
