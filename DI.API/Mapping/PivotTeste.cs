using AutoMapper;
using DI.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static DI.API.Controllers.WeatherForecastController;

namespace DI.API.Mapping
{
    public class PivotTeste : Profile
    {
        public PivotTeste()
        {
            CreateMap<PivotChanges, MetaData>()
                .ForMember(p => p.Id, o => o.MapFrom(p => Teste()));
        }

        private int Teste()
        {
            return 10 * 5;
        }
    }
}
