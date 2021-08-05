using System;

namespace PATTERNS
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo veiculo grande {veiculo.Modelo}");
        }
    }
}
