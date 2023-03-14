
namespace VeiculosTerrestres
{
    internal class Veiculos
    {
        public int Rodas { get; set; }
        public int Passageiros { get; set; }
        public string Cor { get; set; }
        public string Velocidade { get; set; }

        public Veiculos(int rodas, int passageiros, string cor, string velocidade)

        {
            Rodas = rodas;
            Passageiros = passageiros;
            Cor = cor;
            Velocidade = velocidade;
        }

        public override string ToString()
        {
            return Rodas + Passageiros + Cor + Velocidade;
        }
    }

}

