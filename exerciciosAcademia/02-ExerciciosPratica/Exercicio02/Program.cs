// 2 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

Console.WriteLine($"Digite um número: ");
int numero = int.Parse(Console.ReadLine()!);

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}