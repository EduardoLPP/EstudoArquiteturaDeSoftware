namespace OOP._1___POO._01___Classes_e_Objetos
{
    /// <summary>
    /// Definição de Classe: Estrutura de código com a função de mapear um objeto do mundo real
    /// </summary>
    public class Casa
    {
        public int TamanhoM2 { get; set; }
        public int Andares { get; set; }
        public decimal Valor { get; set; }
        public int NumeroVagas {get;set; }
    }

    /// <summary>
    /// Definição de Objeto: Intanciação da Classe, ou seja, ela passa a estar representada na memória como um objeto
    /// </summary>
    public class Objeto
    {
        public Objeto()
        {
            var casa = new Casa()
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3,
            };
        }
    }
}
