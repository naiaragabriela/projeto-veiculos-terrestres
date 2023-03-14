namespace VeiculosTerrestres
{
    internal class Onibus
    {
        public string Catraca { get; set; }
        public Onibus(int rodas, int passageiros, string cor, string velocidade, string catraca) : base(rodas, passageiros, cor, velocidade)
        {
            Catraca = catraca;

        }
        public override string ToString()
        {
            return base.ToString() + " - " + Catraca;
        }

    }


}
