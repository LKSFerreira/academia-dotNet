// Escreva um algoritmo leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim.

Console.WriteLine($"Digite o valor inicial");
int inicio = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor final");
int fim = int.Parse(Console.ReadLine()!);

for (int i = inicio; i <= fim; i++)
{
    Console.WriteLine(i);
}