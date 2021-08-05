using System;

namespace PATTERNS
{
    public class GuinchoCreator
    {
        public static Guincho Criar(Porte Porte)
        {
            switch (Porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(Porte);
                case Porte.Grande:
                    return new GuinchoGrande(Porte);
                case Porte.Medio:
                    return new GuinchoMedio(Porte);
                default:
                    throw new Exception("Porte do Guinho desconhecido");
            }
        }
    }
}
