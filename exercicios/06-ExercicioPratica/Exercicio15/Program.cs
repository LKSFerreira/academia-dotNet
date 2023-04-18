// 15.	Faça um programa em C# que declare um vetor de 20 elementos inteiros, leia os conteúdos do vetor, e copie estes conteúdos para outro vetor, invertendo sua ordem. Assim, o valor do primeiro elemento do primeiro vetor deve ser o valor do último elemento do segundo vetor, por exemplo. Mostrar os conteúdos do primeiro vetor em uma linha e os do segundo uma linha abaixo.

Console.WriteLine($"Informe 20 valores para o vetor:");
int[] vetor = new int[2];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

int[] vetorInvertido = new int[20];

for (int i = 0; i < vetor.Length; i++)
{
    vetorInvertido[i] = vetor[vetor.Length - 1 - i];
}

Console.WriteLine($"Vetor:");
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write($"{vetor[i]} | ");
}

Console.WriteLine($"");
Console.WriteLine($"Vetor invertido:");
for (int i = 0; i < vetorInvertido.Length; i++)
{
    Console.Write($"{vetorInvertido[i]} | ");
}
