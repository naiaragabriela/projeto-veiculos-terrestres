namespace VeiculosTerrestres
{
    internal class Van: Veiculos
    {
        public string PortaAutomatica { get; set; }
        public Van(int rodas, int passageiros, string cor, string velocidade, string portaAutomatica) : base (rodas, passageiros, cor, velocidade)
        {
            PortaAutomatica = portaAutomatica;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + PortaAutomatica;
        }
    }
}
