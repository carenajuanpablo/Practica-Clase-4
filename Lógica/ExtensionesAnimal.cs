using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lógica
{
    //1- Crear un método de extensión que reciba un string y retorne la cantidad de palabras.

    public static class ExtensionesAnimal
    {
        public static int RetornarCantidadPalabras(this Animal animal, string texto)
        {
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ' || i == texto.Length - 1)
                {
                    cont++;
                }
            }
            return cont;
        }
        //2- Crear una sobreescritura del método 1 para que reciba un parámetro adicional char con el separador a usar para contar las palabras.
        public static int RetornarCantidadPalabras(this Animal animal, string texto, char caracter)
        {
            int cont = 0;
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ' || texto[i] == caracter || i == texto.Length - 1)
                {
                    cont++;
                }
            }
            return cont;
        }

        //3- Cree un método de extensión que reciba dos fechas DateTime y calcule su diferencia en segundos y que retorne un decimal con su 
        //formato en minutos (en valor decimal, es de 120 = 2 o 180 = 2,5)
        public static double CalcularDiferenciaEntreFechas(this Animal animal, DateTime Fecha1, DateTime Fecha2)
        {
            var seconds = System.Math.Abs((Fecha1 - Fecha2).TotalSeconds);
            return seconds / 60;
        }

        //4- Crear un método de extensión que reciba una lista de enteros y devuelva su promedio.
        public static double DevolverPromedio(this Animal animal, int[] array)
        {
            int suma = 0;
            for (int i = 0; i < array.Length; i++)
            {
                suma = suma + array[i];
            }

            return suma / array.Length;
        }
        //5- Crear un método de extensión que reciba una lista de enteros y devuelva la suma de los valores pares * la resta de los impares.
        public static double DevolverCalculo(this Animal animal, int[] array)
        {
            int suma = 0;
            int resta = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    suma = suma + array[i];
                }
                else
                {
                    resta = resta - array[i];
                }
            }
            return suma * resta;
        }
        //6- Crear un método de extensión que retorne una fecha en formato DateTime a partir de un string (si se genera una excepción por mal 
        //formato retornar el MinValue del tipo de datos).
        public static DateTime DevolverFecha(this Animal animal, string fecha)
        {
            DateTime resultado;
            DateTime.TryParse(fecha, out resultado);

            return resultado;
        }

        //7- Crear un método de extensión que dado un string, retorne otro invertido.
        public static string DevolverStrignInvertido(this Animal animal, string texto)
        {
            char[] ArregloChars = texto.ToCharArray();
            Array.Reverse(ArregloChars);
            return new string(ArregloChars);
        }


        //8- Crear un método de extensión que dado un array de strings, genere un solo string separado por un parámetro de tipo char.
        public static string ConcatenarStrings(this Animal animal, char separador, string[] array)
        {
            string separadorString = char.ToString(separador);
            string arrayConcatenado = string.Join(separadorString, array);
            return arrayConcatenado;
        }

        //9- Crear un método de extensión que reciba un string y retorne un valor booleano que indique si es un mail o no (investigar Regex).

        //Usando la clase System.Net.Mail.MailAddress
        public static bool ValidaciónMailAddress(this Animal animal, string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Usando REGEX
        public static bool ValidaciónRegex(this Animal animal, string email)
        {
            string patrón = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            if (Regex.IsMatch(email, patrón))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //12- Crear un método de extensión que reste dos números enteros.

        public static int RestaDeNumeros(this Animal animal, int n1, int n2)
        {
            return n1 - n2;
        }

        
    }
}



   




