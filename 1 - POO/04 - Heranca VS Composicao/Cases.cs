using OOP._1___POO._02___Pilares_OOP;
using OOP._1___POO._03___Interface_Vs_Implementacao;

namespace OOP._1___POO._04___Heranca_VS_Composicao
{
    #region Caso 1
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
    }

    public class PessoaFisica02 : Pessoa
    {
        public Pessoa Pessoa { get; set; }
        public string CPF { get; set; }
    }

    public class TestarHerancaComposicao
    {
        public TestarHerancaComposicao()
        {
            var pessoaHeranca = new PessoaFisica()
            {
                Nome = "Luke",
                DataNascimento = DateTime.Now,
                CPF = "32115987626"
            };

            var pessoaComposicao = new PessoaFisica02()
            {
                Pessoa = new Pessoa
                {
                    Nome = "Leia",
                    DataNascimento = DateTime.Now,
                },
                DataNascimento = DateTime.Now,
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nomeComposicao = pessoaComposicao.Pessoa.Nome;
        }
    }
    #endregion

    #region Caso 2
    public interface IRepositorio<T>
    {
        void Adicionar(T obj);

        void Excluir(T obj);
    }

    public interface IRepositorioPessoa
    {
        void Adicionar(Pessoa obj);
    }

    public class Repositorio<T> : IRepositorio<T>
    {
        public void Adicionar(T obj)
        {
            
        }

        public void Excluir(T obj)
        {
            
        }
    }

    public class RepositorioHerancaPessoa : Repositorio<Pessoa>, IRepositorioPessoa
    {
    }

    public class RepositorioComposicaoPessoa : IRepositorioPessoa
    {
        private readonly IRepositorio<Pessoa> _repositorioPessoa;
        
        public void Adicionar(Pessoa obj)
        {
            _repositorioPessoa.Adicionar(obj);
        }

        public RepositorioComposicaoPessoa(IRepositorio<Pessoa> repositorioPessoa)
        {
            _repositorioPessoa = repositorioPessoa;
        }
    }

    public class TesteHerancaComposicao
    {
        public TesteHerancaComposicao()
        {
            var repoH = new RepositorioHerancaPessoa();
            repoH.Adicionar(new Pessoa);
            repoH.Excluir(new Pessoa());

            var repoC = new RepositorioComposicaoPessoa(new Repositorio<Pessoa>());
            repoC.Adicionar(new Pessoa());
        }
    }

    #endregion
}
