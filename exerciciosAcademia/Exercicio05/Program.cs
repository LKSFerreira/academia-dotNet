// 5) Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
// (medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
// consumido para percorrê-la (medido em l).

Console.WriteLine($"Digite a distância total percorrida: ");
double distancia = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o volume de combustível consumido: ");
double combustivel = double.Parse(Console.ReadLine()!);

double consumoMedio = distancia / combustivel;
Console.WriteLine($"O consumo médio é: {consumoMedio} Km/l");