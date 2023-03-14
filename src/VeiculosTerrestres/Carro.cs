
namespace VeiculosTerrestres
{
    internal class Carro : Veiculos
    {
        public string PortaMalas { get; set; }
      
        public Carro( int rodas, int passageiros, string cor, string velocidade, string portaMalas) : base(rodas, passageiros, cor, velocidade)
        {
            PortaMalas = portaMalas;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + PortaMalas;
        }

    }

}
