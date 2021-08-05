using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Praticando_o_Composite
{

    public static class ExecutarPraticandoComposite
    {
        // Classe Consumidora
        public static void Executar()
        {
            var PrimeiraCaixa = new Caixa("CaixaPrincipal", 0M);

            var PrimeiroProtudo = new Produto("produto: camiseta", 50.99M);
            var SegundoProtudo = new Produto("produto: caneca", 20.50M);

            PrimeiraCaixa.AdicionarProduto(PrimeiroProtudo);
            PrimeiraCaixa.AdicionarProduto(SegundoProtudo);

            var SegundaCaixa = new Caixa("Caixa", 0M);

            var TerceirooProtudo = new Produto("produto: garrafa", 30.99M);
            var QuartoProtudo = new Produto("produto: caderno", 10.50M);

            SegundaCaixa.AdicionarProduto(TerceirooProtudo);
            SegundaCaixa.AdicionarProduto(QuartoProtudo);

            PrimeiraCaixa.AdicionarProduto(SegundaCaixa);

            PrimeiraCaixa.CalcularPreco();


        }
    }

    // Classe Leaf
    public class Produto : IProduto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public decimal CalcularPreco()
        {
            Console.WriteLine($"{Nome} | Preço={Preco}");
            return Preco;
        }
    }
}

// Classe Composite
public class Caixa : IProduto
{
    public readonly IList<IProduto> _listProdutos = new List<IProduto>();
    public string Nome { get; set; }
    public decimal Preco { get; set; }

    public Caixa(string nome, decimal preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AdicionarProduto(IProduto produto)
    {
        _listProdutos.Add(produto);
    }

    public decimal CalcularPreco()
    {
        Console.WriteLine($"{Nome}");
        foreach (var produto in _listProdutos)
        {
            Preco +=  produto.CalcularPreco();
        }
        Console.WriteLine($"Preço da {Nome} = {Preco}\n");
        return Preco;
    }
}


// Interface Component

public interface IProduto
{
    public string Nome { get; set; }
    public decimal Preco { get; set; }
    public decimal CalcularPreco();
}
