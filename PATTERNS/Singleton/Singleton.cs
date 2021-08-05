using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS.Singleton
{
    public sealed class Singleton
    {
        //private static readonly Singleton Instance = new Singleton();
        private readonly Admin _admin;

        public Singleton()
        {
            _admin = new Admin { Id = Guid.NewGuid(), Nome = "Administrador" };
        }

        //public static Singleton InstanceCreate()
        //{
        //    return Instance;
        //}
    }
}
