using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.Pilares_OPP
{
    //encapsulamento é chamar um metodo que internamente ele não sabe como
    //funciona pois tem metodos privados que possuem comportamentos que so sao expostos por método públicos
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var expresso = new CafeteiraExpressa();
            expresso.Ligar();
            expresso.PrepararCafe();
            expresso.Desligar();
        }
    }
}
