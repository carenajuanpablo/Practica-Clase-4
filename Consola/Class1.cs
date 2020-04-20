using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lógica;

namespace Consola
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            int cantPalabras = animal.RetornarCantidadPalabras("HOLA QUE TAL");
            Console.Read();
        }

    }
}
