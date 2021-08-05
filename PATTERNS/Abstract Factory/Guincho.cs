namespace PATTERNS
{
    public abstract class Guincho
    {
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public Porte Porte { get; set; }
        public abstract void Socorrer(Veiculo veiculo);
    }
}
