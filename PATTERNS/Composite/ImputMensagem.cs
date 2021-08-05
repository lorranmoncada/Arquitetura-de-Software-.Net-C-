using System;

namespace PATTERNS.Composite
{
    public class ImputMensagem : IMensagem
    {
        public ImputMensagem(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }


        public void ExibirMensages(int sub)
        {
            Console.WriteLine(new string('-', sub) + Nome);
        }
    }
}
