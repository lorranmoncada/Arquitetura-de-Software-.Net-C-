using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Composite
{
    public class Mensagem : IMensagem, IEnumerable<IMensagem>
    {
        private readonly List<IMensagem> _lista = new List<IMensagem>();

        public Mensagem(string mensagem)
        {
            Nome = mensagem;
        }

        public string Nome { get; set; }

        public void ExibirMensages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
            foreach (var mensagem in _lista)
            {
                mensagem.ExibirMensages(sub + 2);
            }
        }

        public void AdicionarFilha(IMensagem filha)
        {
            _lista.Add(filha);
        }

        public void RemoverFilha(IMensagem filha)
        {
            _lista.Remove(filha);
        }

        public IEnumerator<IMensagem> GetEnumerator()
        {
            return (IEnumerator<IMensagem>)_lista.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator<IMensagem>)_lista.GetEnumerator();
        }
    }
}
