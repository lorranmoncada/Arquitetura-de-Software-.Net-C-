using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Observable
{
    public static class ExecutarObservable
    {
        public static void Executando()
        {
            var itausa = new ITausa("ITAU", 15.5M);

            var observador1 = new Observador();
            observador1.Nome = "Lorran";

            var observador2 = new Observador();
            observador2.Nome = "Écila";

            var observador3 = new Observador();
            observador3.Nome = "Bruno";

            itausa.Subscribe(observador1);
            itausa.Subscribe(observador2);
            itausa.Subscribe(observador3);

            itausa.Notificar();

            itausa.Valor = 10M;
        }
    }

    public class ITausa : Investimento
    {
        public ITausa(string simbolo, decimal valor) : base(simbolo, valor)
        {

        }
    }

    public abstract class Investimento
    {
        private decimal _valor;
        private readonly List<IObservador> _observadores = new List<IObservador>();

        protected Investimento(string simbolo, decimal valor)
        {
            _valor = valor;
            Simbolo = simbolo;
        }

        public string Simbolo { get; }
        public decimal Valor
        {
            get => _valor;
            set
            {
                if (_valor == value) return;
                _valor = value;
                Notificar();
            }
        }

        public void Subscribe(IObservador observador)
        {
            _observadores.Add(observador);
            Console.WriteLine($"Notificando que {observador.Nome} esta recebendo atualizações de {Simbolo}");
        }

        public void UnCubscribe(IObservador observador)
        {
            _observadores.Remove(observador);
            Console.WriteLine($"Notificando que {observador.Nome} não esta recebendo atualizações de {Simbolo}");
        }

        public void Notificar()
        {
            foreach (var observador in _observadores)
            {
                observador.Notificar(this);
            }
        }
    }


    public interface IObservador
    {
        string Nome { get; }

        void Notificar(Investimento investimento);
    }

    public class Observador : IObservador
    {
        public string Nome { get; set; }

        public void Notificar(Investimento investimento)
        {
            Console.WriteLine("Notificando {0}" + " que {1}" + " teve o valor alterado para{2:C}", Nome, investimento.Simbolo, investimento.Valor);
        }
    }

}
