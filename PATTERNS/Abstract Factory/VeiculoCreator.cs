using System;

namespace PATTERNS
{
    public class VeiculoCreator
    {
        public static Veiculo Criar(string modelo, Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new VeiculoPequeno(modelo,porte);
                case Porte.Grande:
                    return new VeiculoGrande(modelo, porte);
                case Porte.Medio:
                    return new VeiculoMedio(modelo, porte);
                default:
                    throw new Exception("Porte do Veiculo desconhecido");
            }
        }
    }
}
