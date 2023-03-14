

namespace VeiculosTerrestres
{
    internal class Moto : Veiculos
    {
        public string Capacete { get; set; }

        public Moto(int rodas, int passageiros, string cor, string velocidade, string capacete): base(rodas, passageiros, cor, velocidade)
        {
            Capacete = capacete;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Capacete;
        }
    }
    

}
