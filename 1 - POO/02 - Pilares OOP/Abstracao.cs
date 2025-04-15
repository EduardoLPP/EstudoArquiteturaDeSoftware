namespace OOP._1___POO._02___Pilares_OOP
{
    public abstract class EletroDocmestico 
    {
        private readonly string _nome;
        private readonly int _voltagem;

        protected EletroDocmestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }

        public abstract void Ligar();

        public abstract void Desligar();
    }
}
