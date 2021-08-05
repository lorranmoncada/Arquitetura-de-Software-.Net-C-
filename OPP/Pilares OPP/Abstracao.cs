using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.Pilares_OPP
{
    // Abtraação é criar conceitos genericos que possao ser abstraidos por outras classes
    // atraves de classes genericas criamos uma classe base que servira comportamentos genericos e propriedades para as classes que iram herda-la
   
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected  Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        protected virtual void Testar() {
            // Não implementado
        }
        public abstract void Ligar();
        public abstract void Desligar();

    }
}
