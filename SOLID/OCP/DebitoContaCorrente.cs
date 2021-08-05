using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public static class DebitoContaCorrente
    {

        public static void DebitarContaCorrente(this DebitoConta debitoconta, double valor)
        {
             debitoconta.Valor = debitoconta.Valor - valor;
        }
    }
}
