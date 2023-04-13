// 5.	Escreva um algoritmo que leia um vetor de 80 elementos inteiros. Encontre e mostre o menor elemento e a sua posição.

Console.WriteLine($"Informe 80 valores para o vetor:");
int[] vetor = new int[80];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

int menorValor = vetor[0];
int posicaoMenorValor = 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] < menorValor)
    {
        menorValor = vetor[i];
        posicaoMenorValor = i;
    }
}

Console.WriteLine($"O menor valor é {menorValor} e está na posição {posicaoMenorValor}");
