using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.Pilares_OPP
{
    public class Funcionario : Pessoa
    {
        public string Registro { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public class Processo
    {
        public Funcionario Executar()
        {
            var funcionario = new Funcionario
            {
                Nome = "Lorran",
                DataNascimento = new DateTime(1996, 06, 18),
                DataAdmissao = new DateTime(2021, 03, 22),
                Registro = "123456789"
            };

            return funcionario;
        }

    }
}
