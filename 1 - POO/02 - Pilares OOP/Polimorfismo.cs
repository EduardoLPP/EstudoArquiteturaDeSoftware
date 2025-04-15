namespace OOP._1___POO._02___Pilares_OOP
{
    public class CafeteiraExpresa : Eletrodomestico
    {
        public CafeteiraExpresa(string nome, int voltagem) : base(nome, voltagem){ }

        public CafeteiraExpresa() : base("Padrão", 220){ }

        private static void AquecerAgua() { }
        private static void MoerGraos() { }

        public void PrepararCafe()
        {
            Testar();
            AquecerAgua();
            MoerGraos();
            //ETC
        }

        public override void Ligar()
        {
           //Verificar recipiente de água
        }

        public override void Desligar()
        {
            //Resfriar aquecedor
        }
    }
}
