// 11.	Escreva um programa que leia valores em um vetor de 5 posições. Escrever os elementos do vetor e após escrever os elementos na ordem inversa.

Console.WriteLine($"Informe 5 valores para o vetor:");
int[] vetor = new int[5];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Vetor:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($"{vetor[i]} | ");
}

Console.WriteLine($"");

Console.WriteLine($"Vetor invertido:");
for (int i = vetor.Length - 1; i >= 0; i--)
{
    Console.Write($"{vetor[i]} | ");
}
