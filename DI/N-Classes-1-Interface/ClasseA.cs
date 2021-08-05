using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI.N_Classes_1_Interface
{
    public class ClasseA : IUnicaInterface
    {
        public string RetornarAlgo()
        {
            return nameof(ClasseA);
        }
    }
}
