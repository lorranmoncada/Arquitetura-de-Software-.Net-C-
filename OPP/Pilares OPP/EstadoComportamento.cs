using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.Pilares_OPP
{
    public class Pessoa
    {
        // Estado da Classe
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNascimento { get; set;}

        // Comportamento de uma classe que pode tambem alterar o estado da entidade
        public void CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            var dataNacimentoAnoAtual = DataNascimento.AddYears(idade);

            if (dataAtual < dataNacimentoAnoAtual) --idade;

            Idade = idade;
         
        }
    }
}
