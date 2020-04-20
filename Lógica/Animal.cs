using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class Animal
    {
        public string Tipo { get; set; }
        public string Color { get; set; }
        public int Numero { get; set; }



        //13- Sobreescribir el operador / de dos números enteros para que retorne el valor decimal.

        public static decimal operator /(Animal n1, Animal n2)
        {
            decimal rtado = Convert.ToDecimal(n1.Numero) / Convert.ToDecimal(n2.Numero);
            return rtado;

        }
    }
}
