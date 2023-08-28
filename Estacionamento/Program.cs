using Estacionamento;

Carro carro1 = new Carro();
carro1.Placa = "ABC1234";
carro1.Descricao = "Fiat Argo";
carro1.CorExterna = Carro.Cor.Branca;

Carro carro2 = new Carro();
carro2.Placa = "DEF5678";
carro2.Descricao = "VW Gol";
carro2.CorExterna = Carro.Cor.Azul;

Carro carro = new("GHIJ9876", "GM Ônix", Carro.Cor.Vermelha, 5);
carro.Mostrar();