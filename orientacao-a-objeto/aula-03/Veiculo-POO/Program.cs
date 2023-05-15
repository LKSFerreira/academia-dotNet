// Criar uma classe Veiculo que contém as propriedades Marca e Modelo. Criar duas classes derivadas, Carro e Moto, que herdam de Veiculo. A classe Carro deve ter uma propriedade adicional QuantidadeDePortas, enquanto a classe Moto deve ter uma propriedade adicional Cilindrada. Criar um método Dirigir na classe Veiculo que imprime "Dirigindo o <marca> <modelo>". Em seguida, criar um método Dirigir na classe Carro que imprime "Dirigindo o <marca> <modelo> com <quantidadeDePortas> portas" e um método Dirigir na classe Moto que imprime "Dirigindo a <marca> <modelo> com <cilindrada> cilindradas".

using Veiculo_POO.Model;

Carro veiculo = new Carro();
veiculo.Marca = "Renault";
veiculo.Modelo = "Sandeiro";
Console.WriteLine($"Quantidade de portas: {veiculo.QuantidadeDePortas}");
veiculo.Ligar();
veiculo.Dirigindo();

Console.WriteLine($"===============================");

Moto moto = new Moto();
moto.Marca = "Tesla";
moto.Modelo = "Model S";
moto.Ligar();
moto.Dirigindo();

