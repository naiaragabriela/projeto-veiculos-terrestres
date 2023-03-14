using VeiculosTerrestres;

    Carro carro = new Carro(4, 5, " vermelho ", " 110Km/h ", " Porta Malas");
    Moto moto = new Moto(2, 2, " azul ", " 80Km/h ", " Capacete");
    Onibus onibus = new Onibus(6, 45, " verde ", " 60Km/h ", " Catraca");
    Van van = new Van(4, 16, "branca", "110Km/h", "Porta Automatica");



    Console.WriteLine(carro.ToString());

    Console.WriteLine(moto.ToString());

    Console.WriteLine(onibus.ToString());

    Console.WriteLine(van.ToString());
