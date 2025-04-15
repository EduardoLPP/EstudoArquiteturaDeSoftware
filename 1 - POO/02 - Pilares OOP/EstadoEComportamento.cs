using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP._1___POO._02___Pilares_OOP
{
    /// <summary>
    /// O estado é representado pelas propriedades (atributos) da classe: Nome, Data Nascimento.
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// O comportamento é quando uma nova informação é processada através da classe: Transformar a DataNascimento em uma idade;
        /// Comportamentos (métodos) podem alterar o valor do Estado da classe.
        /// </summary>
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}
