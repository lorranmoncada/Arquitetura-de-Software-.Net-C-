using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.Pilares_OPP
{

    // Polimorfismo porque o eletrodomestico assume comportamentos diferentes deacordo com a classe que a herda-la
    public class CafeteiraExpressa : Eletrodomestico
    {
        public CafeteiraExpressa(string nome, int voltagem):base(nome, voltagem){ }

        public CafeteiraExpressa():base("Padrão", 220){}

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
        }


        protected override void Testar()
        {
            // sobrescrevendo o metodo teste
        }
        private void AquecerAgua()
        {
            // Aquece a agua
        }

        private void MoerGraos()
        {
            // Aquece a agua
        }

        public override void Desligar()
        {
            throw new NotImplementedException();
        }

        public override void Ligar()
        {
            throw new NotImplementedException();
        }
    }
}
