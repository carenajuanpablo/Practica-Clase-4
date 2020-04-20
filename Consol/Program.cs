using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lógica;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            int cantPalabras = animal.RetornarCantidadPalabras("HOLA QUE TAL");
            int cantPalabrasSeparador = animal.RetornarCantidadPalabras("HOLA QUE TAL",'A');
            Console.WriteLine(cantPalabras+" palabras separadas por ''");
            Console.WriteLine(cantPalabrasSeparador+" palabras separadas por un caracter y por ''");

            DateTime fecha1 = new DateTime(2012, 2, 4, 10, 15, 30);
            DateTime fecha2 = new DateTime(2012, 2, 4, 10, 12, 30);

            double DiferenciaMinutos = animal.CalcularDiferenciaEntreFechas(fecha1,fecha2);
            Console.WriteLine(DiferenciaMinutos+" minutos");


            int[] arreglo = { 2, 3, 4, 5, 6 };
            double Promedio = animal.DevolverPromedio(arreglo);
            Console.WriteLine("Promedio: "+Promedio);

            double Calculo = animal.DevolverCalculo(arreglo);
            Console.WriteLine("Calculo: " + Calculo);

            string fechaValida = "05/05/2005";
            DateTime FechaConvertida = animal.DevolverFecha(fechaValida);
            Console.WriteLine(FechaConvertida);

            string fechaInvalida = "45/15/1990";
            DateTime FechaConvertida2 = animal.DevolverFecha(fechaInvalida);
            Console.WriteLine(FechaConvertida2);


            string TextoInvertido = animal.DevolverStrignInvertido("MI NOMBRE ES SAM");
            Console.WriteLine(TextoInvertido);

            string[] Array = { "Hola", "cuál es", "tu nombre?" };          
            string ConcatenaciónArrays = animal.ConcatenarStrings('/',Array);
            Console.WriteLine(ConcatenaciónArrays);


            string email = "TomasShelby@gmail.com";
            bool resultado = animal.ValidaciónMailAddress(email);
            string email2 = "$$$Shelbygmail.com";

            bool resultado2 = animal.ValidaciónRegex(email2);

            //-----------------------------------
            ClienteA CA1 = new ClienteA();
            CA1.Nombre = "Pedro";
            CA1.CUIT = 2034043345;
            CA1.Saldo = 500;

            ClienteA CA2 = new ClienteA();
            CA2.Nombre = "Pedro";
            CA2.CUIT = 2034043345;
            CA2.Saldo = 300;

            ClienteA CAT = new ClienteA();
            CAT = CA1 - CA2;
            Console.WriteLine(CAT.Saldo);

            //-----------------------------------
            ClienteB CB1 = new ClienteB();
            CB1.Nombre = "juan";
            CB1.CUIT = 2034043345;
            CB1.Saldo = 200;

            ClienteB CB2 = new ClienteB();
            CB2.Nombre = "Mario";
            CB2.CUIT = 1114043345;
            CB2.Saldo = 300;

            ClienteB CBT = new ClienteB();
            CBT = CB1 - CB2;
            Console.WriteLine(CBT.Saldo);

            //-----------------------------------
            Animal An1 = new Animal();
            An1.Numero = 5;


            Animal An2 = new Animal();
            An2.Numero = 4;

            decimal RTADO;
            RTADO = An1 / An2;
            Console.WriteLine(RTADO);


            Console.Read();

        }
    }
}
