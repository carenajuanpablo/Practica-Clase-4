using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class ClienteA
    {
        //10- Cree dos clases cliente (nombre, cuit, saldo). Sobrecargue el operador de resta para que:
        //a. si los cuits son iguales: que retorne un cliente con saldo = resta de los dos saldos.

        public string Nombre { get; set; }
        public int CUIT { get; set; }
        public double Saldo { get; set; }

        public static ClienteA operator - (ClienteA C1, ClienteA C2 )
        {
            if (C1.CUIT == C2.CUIT)
            {
                ClienteA nuevoCliente = new ClienteA();
                if (C1.Saldo > C2.Saldo)
                {
                    nuevoCliente.Saldo = C1.Saldo - C2.Saldo;
                    return nuevoCliente;
                }
                else
                {
                    nuevoCliente.Saldo = C2.Saldo - C1.Saldo;
                    return nuevoCliente;
                }
            }
            else
            {
                //Duda acerca de que devolver
                return C1 -C2;
            }

        }
    }
}
