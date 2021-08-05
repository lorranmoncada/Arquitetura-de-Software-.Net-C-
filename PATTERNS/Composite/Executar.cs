using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Composite
{
    public class Executar
    {
        public void ExecutarFuncao()
        {
            var mensagemPai = new Mensagem("Mensagem Pai");

            var mensagemFilha1 = new ImputMensagem("Primeira Mensagem");
            var mensagemFilha2 = new ImputMensagem("Segunda Mensagem");

            mensagemPai.AdicionarFilha(mensagemFilha1);
            mensagemPai.AdicionarFilha(mensagemFilha2);

            var mensagemFilha3 = new DomainMensagem("Terceira mensagem");
            var mensagemFilha4 = new DomainMensagem("Quarta mensagem");

            var mensagemPai2 = new Mensagem("Mensagem Pai Dominio");

            mensagemPai2.AdicionarFilha(mensagemFilha3);
            mensagemPai2.AdicionarFilha(mensagemFilha4);

            mensagemPai.AdicionarFilha(mensagemPai2);

            mensagemPai.ExibirMensages(2);
        }


    }
}
