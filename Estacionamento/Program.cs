using Estacionamento;

/*
Marca marca = new("FIAT");
Modelo modelo = new(marca, "Argo");
Carro carro = new();
carro.Placa = "ABC1234";
carro.Modelo = modelo;
carro.Descricao = "Carro do Evandro";
carro.CorExterna = Veiculo.Cor.Branca;
carro.Mostrar();
*/

Carro carro = new(
    "ABC1234",
    new(new("FIAT"), "Argo"),
    "Carro do Evandro",
    Veiculo.Cor.Branca,
    5);
carro.Mostrar();

Moto moto = new(
    "DEF5678",
    new(new("Kawasaki"), "Ninja"),
    "Moto do Evandro",
    Veiculo.Cor.Verde,
    false);
moto.Mostrar();
