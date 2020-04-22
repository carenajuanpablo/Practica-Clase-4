using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ClienteB
    {
        //10- Cree dos clases cliente (nombre, cuit, saldo). Sobrecargue el operador de resta para que:
        //b. si son distintos: retorne un cliente con saldo = saldo menor de los dos clientes.

        //ESTABA MAL EL ENUNCIADO, ERA 1 SOLA CLASE, DOS INSTANCIAS DE LA MISMA. CON ESTA CLASE O LA OTRA SOLAS ES SUFICIENTE.

        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public int Saldo { get; set; }

        public static ClienteB operator -(ClienteB C1, ClienteB C2)
        {
            if (C1.CUIT != C2.CUIT)
            {
                int Min = Math.Min(C1.Saldo, C2.Saldo);
                ClienteB nuevoCliente = new ClienteB();
                Random random = new Random();
                nuevoCliente.Saldo = random.Next(0, Min);
                return nuevoCliente;
            }
            else
            {
                //Duda acerca de que devolver
                return C1-C2;
            }

        }
    }
}
