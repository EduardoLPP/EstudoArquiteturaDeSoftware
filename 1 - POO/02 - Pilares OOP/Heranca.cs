using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._1___POO._02___Pilares_OOP
{
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }    
    }

    public class Processo
    {
        public void Execucao()
        {
            var funcionario = new Funcionario()
            {
                Nome =  "Luke Skywalker",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456"
            };

            funcionario.CalcularIdade();
        }
    }
}
