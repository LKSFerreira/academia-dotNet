// 2) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.

Console.WriteLine($"Digite o primeiro número: ");
double valor01 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
double valor02 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o terceiro número: ");
double valor03 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o quarto número: ");
double valor04 = double.Parse(Console.ReadLine()!);

double mediaEntreQuatroNumeros = (valor01 + valor02 + valor03 + valor04) / 4;
Console.WriteLine($"A média entre os quatro números é: {mediaEntreQuatroNumeros.ToString("F2")}");
