using System;

namespace PATTERNS
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo veiculo pequeno {veiculo.Modelo}");
        }
    }
}
