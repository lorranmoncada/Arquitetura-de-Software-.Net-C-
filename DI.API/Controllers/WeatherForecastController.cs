using AutoMapper;
using DI.API.Model;
using DI.N_Classes_1_Interface;
using DI.Provider;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PATTERNS.Adapter;
using PATTERNS.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : Controller
    {
        private readonly CenariosService _cenariosService;
        private readonly IMapper _mapper;
        private readonly Singleton _single;

        //anti patern service locator
        private readonly IServiceProvider _serviceProvider;
        // uma tipo de service locattor
        private readonly Func<string, IUnicaInterface> _meuServiceAcessor;

        private readonly Dictionary<TesteEnum, Func<IServiceEstudo>> _meuSegundoServiceAcessor;

        private readonly ConfigProvider _configProvider;

        private IDebitar _debitar;
        public WeatherForecastController(
            IMapper mapper,
            IServiceProvider serviceProvider, 
            CenariosService cenariosService,
            Func<string, IUnicaInterface> meuServiceAcessor,
            Dictionary<TesteEnum, Func<IServiceEstudo>> meuSegundoServiceAcessor,
            ConfigProvider configProvider,
            Singleton single,
            IDebitar debitar)
        {
            _mapper = mapper;
            _cenariosService = cenariosService;
            _meuServiceAcessor = meuServiceAcessor;
            _serviceProvider = serviceProvider;
            _meuSegundoServiceAcessor = meuSegundoServiceAcessor;
            _configProvider = configProvider;
            _single = single;
            _debitar = debitar;
        }

        public void Index()
        {
            var teste = _cenariosService.Scoped.teste(5);

            var tedt1 = _cenariosService.Scoped.IdCenario;
            var tedt2 = _cenariosService.Singleton.IdCenario;
            var tedt3 = _cenariosService.SingletonInstance.IdCenario;
            var tedt4 = _cenariosService.Transient.IdCenario;
        }

        [HttpGet]
        [Route("acessor")]
        public string ServiceProviderDictionary()
        {
            var teste = _meuSegundoServiceAcessor[TesteEnum.Teste3]();

            return teste.RetornaNomeClasse();
        }

        [HttpGet]
        [Route("singleton")]
        public void ServiceSingleton()
        {
            var teste = _single;
            var teste1 = _single;

        }

        [HttpGet]
        [Route("outroacessor")]
        public int ServiceProvedor()
        {
            return _configProvider.ServicoProvedor.soma(1, 3);
        }

        [HttpGet]
        [Route("adapter1")]
        public string Adapter1()
        {
            _debitar = _serviceProvider.GetService<Debitar>();
           return _debitar.DebitarValor();
        }

        [HttpGet]
        [Route("adapter2")]
        public string Adapter2()
        {
            _debitar = _serviceProvider.GetService<AdapterDebitarMaster>();
            return _debitar.DebitarValor();
        }

        #region
        [HttpGet]
        [Route("teste")]
        public string ServiceProviderTeste()
        {
            var testeInterfaceLocator = _meuServiceAcessor("C").RetornarAlgo();

            return testeInterfaceLocator;
        }

        [HttpGet]
        [Route("service")]
        public void ServiceLocatorPattern()
        {
            var service = _serviceProvider.GetRequiredService<IScoped>().teste(3);
        }
        #endregion

        public class PivotChanges
        {
            public PivotOptions Options { get; set; }
            public List<PivotFields> Fields { get; set; }


            public class PivotOptions
            {
                public string rowHeaderLayout { get; set; }
                public bool showColumnFields { get; set; }
                public bool showDataFields { get; set; }
                public bool showFilterFields { get; set; }
                public bool showRowFields { get; set; }
            }

            public class PivotFields
            {
                public bool AllowExpandAll { get; set; }
                public bool AllowFiltering { get; set; }
                public bool AllowSorting { get; set; }
                public bool AllowSortingBySummary { get; set; }
                public string Area { get; set; }
                public int AreaIndex { get; set; }
                public string Caption { get; set; }
                public string DataField { get; set; }
                public string DataType { get; set; }
                public string DisplayFolder { get; set; }
                public bool? Expanded { get; set; }
                public string FilterType { get; set; }
                public List<dynamic> FilterValues { get; set; }
                public int Index { get; set; }
                public string SortBy { get; set; }
                public string SortBySummaryField { get; set; }
                public string SortOrder { get; set; }
                public int Width { get; set; }
                public string SummaryType { get; set; }

            }
        }


    }
}
