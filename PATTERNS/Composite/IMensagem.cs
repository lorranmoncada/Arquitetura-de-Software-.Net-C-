namespace PATTERNS.Composite
{
    public interface IMensagem
    {
        string Nome { get; set; }
        void ExibirMensages(int sub);
    }
}
