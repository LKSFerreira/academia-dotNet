Console.WriteLine($"Digite o primeiro número: ");
double valor01 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo número: ");
double valor02 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Para qual operação deseja realizar? Digite:");
Console.WriteLine($"1 - Soma");
Console.WriteLine($"2 - Subtração");
Console.WriteLine($"3 - Multiplicação");
Console.WriteLine($"4 - Divisão");

int operacao = int.Parse(Console.ReadLine()!);

if (operacao == 1)
{
    double resultado = valor01 + valor02;
    Console.WriteLine($"O resultado da soma é: {resultado.ToString("F2")}");
}
else if (operacao == 2)
{
    double resultado = valor01 - valor02;
    Console.WriteLine($"O resultado da subtração é: {resultado.ToString("F2")}");
}
else if (operacao == 3)
{
    double resultado = valor01 * valor02;
    Console.WriteLine($"O resultado da multiplicação é: {resultado.ToString("F2")}");
}
else if (operacao == 4)
{
    double resultado = valor01 / valor02;
    Console.WriteLine($"O resultado da divisão é: {resultado.ToString("F2")}");
}
else
{
    Console.WriteLine($"Operação inválida!");
}
