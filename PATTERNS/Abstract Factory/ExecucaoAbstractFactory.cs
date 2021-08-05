using PATTERNS.Abstract_Factory.Classe_Consumidora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Abstract_Factory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            var veiculosSocorro = new List<Veiculo>
            {
              VeiculoCreator.Criar("Celta", Porte.Pequeno),
              VeiculoCreator.Criar("Jetta", Porte.Medio),
              VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

            veiculosSocorro.ForEach(v => AutoSocorro.CriarAutoSocorro(v).RealizarAtendimento());
        }
    }
}