using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Abstract_Factory.Classe_Consumidora
{
    public class AutoSocorro
    {

        private readonly Veiculo _veiculo;
        private readonly Guincho _guincho;

        public AutoSocorro(AutoSocorroFactory autoSocorroFactory, Veiculo veiculo)
        {
            _veiculo = autoSocorroFactory.CriarVeiculo(veiculo.Modelo,veiculo.Porte);
            _guincho = autoSocorroFactory.CriarGuincho();
        }

        public void RealizarAtendimento()
        {
            _guincho.Socorrer(_veiculo);
        }

        public static AutoSocorro CriarAutoSocorro(Veiculo veiculo)
        {
            switch (veiculo.Porte)
            {
                case Porte.Pequeno:
                    return new AutoSocorro(new SocorroVeiculoPequenoFactory(), veiculo);
                case Porte.Grande:
                    return new AutoSocorro(new SocorroVeiculoGrandeFactory(), veiculo);
                case Porte.Medio:
                    return new AutoSocorro(new SocorroVeiculoMedioFactory(), veiculo);
                default:
                    throw new Exception("Porte do Guinho desconhecido");
            }
        }

    }
}
