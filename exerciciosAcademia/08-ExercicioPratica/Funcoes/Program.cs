Console.WriteLine($"Digite dois valores para serem usado nas funções: ");

Console.WriteLine($"Digite o primeiro valor: ");
double valor1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo valor: ");
double valor2 = double.Parse(Console.ReadLine()!);

double resultado = soma(valor1, valor2);
Console.WriteLine($"O resultado da soma é: {resultado}");

Console.WriteLine($"====================================");

resultado = subtracao(valor1, valor2);
Console.WriteLine($"O resultado da subtração é: {resultado}");

Console.WriteLine($"====================================");

resultado = multiplicacao(valor1, valor2);

Console.WriteLine($"O resultado da multiplicação é: {resultado}");

Console.WriteLine($"====================================");

resultado = divisao(valor1, valor2);

double divisao(double valor1, double valor2)
{
    return valor1 / valor2;
}

Console.WriteLine($"O resultado da divisão é: {resultado}");

Console.WriteLine($"====================================");

double multiplicacao(double valor1, double valor2)
{
    return valor1 * valor2;
}

double subtracao(double valor1, double valor2)
{
    return valor1 - valor2;
}

double soma(double valor1, double valor2)
{
    return valor1 + valor2;
}