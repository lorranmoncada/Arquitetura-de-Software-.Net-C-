using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.API.Model
{
    public class MetaData
    {
        public int Id { get; set; }
        public byte[] MetaDado { get; set; }
        public Guid IdUsuario { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
