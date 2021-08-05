using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Adapter
{
    public class Debitar : IDebitar
    {
        public string DebitarValor()
        {
            return "Debita Valor padrão";
        }
    }

    public interface IDebitar
    {

        public string DebitarValor();
    }

    public class DebitarMaster : IDebitarMaster
    {
        public string DebitarValorOutraForma()
        {
            return "Debita Valor de outra forma";
        }
    }

    public interface IDebitarMaster
    {
        public string DebitarValorOutraForma();
    }

    public class AdapterDebitarMaster : IDebitar
    {
        private readonly IDebitarMaster _debitarMaster;

        public AdapterDebitarMaster(IDebitarMaster debitarMaster)
        {
            _debitarMaster = debitarMaster;
        }

        public string DebitarValor()
        {
            return _debitarMaster.DebitarValorOutraForma();
        }
    }

}
