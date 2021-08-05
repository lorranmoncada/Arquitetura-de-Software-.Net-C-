using System;

namespace PATTERNS
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte)
        {
        }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine($"Socorrendo veiculo medio {veiculo.Modelo}");
        }
    }
}
