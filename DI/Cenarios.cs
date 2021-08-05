using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    public class CenariosService
    {
        public CenariosService(IScoped scoped, ITransient transient, ISingleton singleton, ISingletonInstance singletonInstance)
        {
            Scoped = scoped;
            Transient = transient;
            Singleton = singleton;
            SingletonInstance = singletonInstance;
        }

        public IScoped Scoped { get; }
        public ITransient Transient { get; }
        public ISingleton Singleton { get; }
        public ISingletonInstance SingletonInstance { get; }
    }

    public class Cenario : IScoped, ITransient, ISingleton, ISingletonInstance
    {
        public Cenario() : this(Guid.NewGuid())
        {

        }

        public Cenario(Guid newGuid)
        {
            IdCenario = newGuid;
        }

        public Guid IdCenario { get; private set; }

        public int teste(int variavel)
        {
            return variavel * 2;
        }
    }

    public interface ICenario
    {
        Guid IdCenario { get; }
    }

    public interface IScoped : ICenario
    {
        int teste(int variavel);
    }
    public interface ITransient : ICenario { }
    public interface ISingleton : ICenario { }
    public interface ISingletonInstance : ICenario { }

}
