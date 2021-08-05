using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATTERNS
{
    public enum Porte
    {
        [Display(Name = "Modelo Grande")]
        Grande,
        [Display(Name = "Modelo Medio")]
        Medio,
        [Display(Name = "Modelo Pequeno")]
        Pequeno

    }
}
