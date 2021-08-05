using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.Provider
{
    public class ConfigProvider
    {
        public IServicoProvedor ServicoProvedor { get; set; }
    }

    public interface IServicoProvedor
    {
        public int soma(int val, int val1);
    }

    public class Soma : IServicoProvedor
    {
        public int soma(int val, int val1)
        {
            return val + val1;
        }
    }
}
