using System;

namespace PATTERNS
{
    [Serializable]
    public class VeiculoGrande : Veiculo
    {
        public VeiculoGrande(string modelo, Porte porte) : base(modelo, porte)
        {
        }
    }
}
