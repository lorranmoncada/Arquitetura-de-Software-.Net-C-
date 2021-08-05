using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Provider
{
    public class Provider
    {
    }

    public interface IServiceEstudo
    {
        public string RetornaNomeClasse();
    }

    public class Teste1 : IServiceEstudo
    {
        public string RetornaNomeClasse()
        {
            return this.GetType().Name;
        }
    }

    public class Teste2 : IServiceEstudo
    {
        public string RetornaNomeClasse()
        {
            return this.GetType().Name;
        }
    }

    public class Teste3 : IServiceEstudo
    {
        public string RetornaNomeClasse()
        {
            return this.GetType().Name;
        }
    }

    public enum TesteEnum
    {
        Teste1,
        Teste2,
        Teste3
    }
}
