using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    public class DebitoConta
    {
        public string NumeroConta { get; set; }
        public double Valor { get; set; }
        public int NumeroTransacao { get; private set; }

        public int GerarNumeroTransacao()
        {
            NumeroTransacao = new Random(15).Next();

            return NumeroTransacao;
        }
    }
}
