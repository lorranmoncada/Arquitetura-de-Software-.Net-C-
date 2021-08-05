using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Patricando_o_Factory_Method
{

    public class ExecutarTeste
    {
        public void Executar()
        {
            FuncionarioFactory.CriarFuncionario(FuncionarioEnum.Clt)
                .FolhaPagamento()
                .AplicarDesconto();
        }
    }

    //creator abstract class
    public abstract class FuncionarioFactory
    {
        // Factory Method
        public abstract Desconto FolhaPagamento();

        public static FuncionarioFactory CriarFuncionario(FuncionarioEnum tpFuncionario)
        {
            switch (tpFuncionario)
            {
                case FuncionarioEnum.Clt:
                    return new FuncionarioClt();
                case FuncionarioEnum.Pj:
                    return new FuncionarioPj();
                case FuncionarioEnum.Cooperado:
                    return new FuncionarioCooperado();
                default:
                    throw new Exception("Modelo de funcionário não encontrado");
            }
        }

    }

    public class FuncionarioClt : FuncionarioFactory
    {
        public override Desconto FolhaPagamento()
        {
            return new DescontoClt();
        }
    }

    public class FuncionarioPj : FuncionarioFactory
    {
        public override Desconto FolhaPagamento()
        {
            return new DescontoPj();
        }
    }

    public class FuncionarioCooperado : FuncionarioFactory
    {
        public override Desconto FolhaPagamento()
        {
            return new DescontoCooperado();
        }
    }

    public abstract class Desconto
    {
        public abstract void AplicarDesconto();
    }

    public class DescontoClt : Desconto
    {
        public override void AplicarDesconto()
        {
            Console.WriteLine("aplicando desconto clt");
        }
    }

    public class DescontoPj : Desconto
    {
        public override void AplicarDesconto()
        {
            Console.WriteLine("aplicando desconto pj");
        }
    }

    public class DescontoCooperado : Desconto
    {
        public override void AplicarDesconto()
        {
            Console.WriteLine("aplicando desconto cooperado");
        }
    }

    public enum FuncionarioEnum
    {
        Clt,
        Pj,
        Cooperado
    }
}
