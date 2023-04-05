// 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

Console.WriteLine($"Digite o primeiro número: ");
double valor01 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
double valor02 = double.Parse(Console.ReadLine()!);

double mediaEntreDoisNumeros = (valor01 + valor02) / 2;
Console.WriteLine($"A média entre os dois números é: {mediaEntreDoisNumeros.ToString("F2")}");