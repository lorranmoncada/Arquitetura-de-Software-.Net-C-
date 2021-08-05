using OPP.Pilares_OPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP.HerancaVsComposicao
{
    public interface IRepository<T>
    {
        void Adicionar(T objeto);
        void Excluir(T objeto);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Adicionar(T objeto)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T objeto)
        {
            throw new NotImplementedException();
        }
    }

    public interface IRepositoryPessoa
    {
        void Adicionar(Pessoa pessoa);
    }

    public class RepositoryPessoa : Repository<Pessoa>, IRepositoryPessoa
    {

    }

    // Herança de repositorio
    // aqui eu consigo enxergar o método de excluir pois uso DI em cima da minha interface Generica so que eu quero deixar exposto somente o método de Adicionar
    public class TesteHerancaRepository
    {
        private readonly IRepository<Pessoa> _repoPessoa;
        public TesteHerancaRepository(IRepository<Pessoa> repoPessoa)
        {
            _repoPessoa = repoPessoa;
        }
        public void Adicionar()
        {
            _repoPessoa.Adicionar(new Pessoa());
            _repoPessoa.Excluir(new Pessoa());
        }
    }

    //Composição de repositorio
    // aqui eu enchergo somente o méodo de adicionar pois estou usando DI em cima do meu reposiitorio IRepositoryPessoa que possui somente o método adicionar
    public class TestecomposicaoRepository
    {
        private readonly IRepositoryPessoa _repoPessoa;
        public TestecomposicaoRepository(IRepositoryPessoa repoPessoa)
        {
            _repoPessoa = repoPessoa;
        }
        public void Adicionar()
        {
            _repoPessoa.Adicionar(new Pessoa());
        }
    }
}
