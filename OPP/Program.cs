using DI;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using OPP.Pilares_OPP;
using PATTERNS;
using PATTERNS.Abstract_Factory;
using PATTERNS.Composite;
using PATTERNS.Factory_Method;
using PATTERNS.Observable;
using PATTERNS.Patricando_o_Factory_Method;
using PATTERNS.Praticando_o_Composite;
using PATTERNS.Singleton;
using SOLID.OCP;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;

namespace OPP
{
    public static class ByteArraySerializer
    {
        public static byte[] Serialize<T>(this T m)
        {
            using (var ms = new MemoryStream())
            {
                new BinaryFormatter().Serialize(ms, m);
                return ms.ToArray();
            }
        }

        public static T Deserialize<T>(this byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return (T)new BinaryFormatter().Deserialize(ms);
            }
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            ExecutarObservable.Executando();
            //ExecutarPraticandoComposite.Executar();

            //new Executar().ExecutarFuncao();



            // string pattern = @"^(?=.*SELECT.*FROM)(?!.*(?:CREATE|DROP|UPDATE|INSERT|ALTER|DELETE|ATTACH|DETACH)).*$";

            // Regex rg = new Regex(pattern, RegexOptions.IgnoreCase);

            // string authors = "SELECT detee FROM table_name WHERE condition = 'asd'; ";


            // MatchCollection matchedAuthors = rg.Matches(authors);

            //var errors = new List<string>();
            // TSql140Parser parser = new TSql140Parser(false);
            // TSqlFragment fragment;
            // IList<ParseError> parseErrors;

            // using (TextReader reader = new StringReader(authors))
            // {
            //     fragment = parser.Parse(reader, out parseErrors);
            //     if (parseErrors != null && parseErrors.Count > 0)
            //     {
            //         errors = parseErrors.Select(e => e.Message).ToList();
            //     }
            // }


            //var a1 = new Singleton();
            //var a2 = new Singleton();

            //if (a1 == a2)
            //{
            //    var foi = "foi sim";
            //}
            //new ExecutarTeste().Executar();
            //ExecucaoFactoryMethod.Executar();

            //var teste = new VeiculoGrande("celta", Porte.Grande);

            //var result = ByteArraySerializer.Serialize(teste);
            //var re = ByteArraySerializer.Deserialize<VeiculoGrande>(result);


            //var funcionarios = Executar.ExecutarCricao();
            // funcionarios.ForEach(f => f.Admicao());

            //var lista = new List<string>() { "filme1", "filme2", "filme3", "filme4" };

            //var listaTake = lista.Skip(3).Take(1);

            //// POO"Lorran", new DateTime(1996, 06, 18)
            //var pessoa = new Pessoa() { Nome = "Lorran", DataNascimento = new DateTime(1996, 06, 18) };

            //pessoa.CalcularIdade();
            //Console.WriteLine(string.Format("Nome: {0}, Idade: {1}",pessoa.Nome, pessoa.Idade));

            //// Herança
            //var funcionario = new Processo().Executar();

            //funcionario.CalcularIdade();

            //Console.WriteLine(string.Format("Nome: {0}, Idade: {1}, Registro: {2}", funcionario.Nome, funcionario.Idade, funcionario.Registro));






            //var debito = new DebitoConta() {NumeroConta = "12345678990", Valor = 100 };

            //debito.GerarNumeroTransacao();

            //Console.WriteLine(String.Format("{0}", debito.Valor));

            //debito.DebitarContaCorrente(50);

            //Console.WriteLine(String.Format("{0}", debito.Valor));
        }
    }
}
