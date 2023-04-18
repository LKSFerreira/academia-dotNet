// 3.	Escreva um algoritmo que leia os valores para um vetor de 20 elementos e então mostre na tela o índice da posição dos valores correspondentes a números primos.

Console.WriteLine($"Informe 20 valores para o vetor:");
int[] vetor = new int[20];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

for (int i = 0; i < vetor.Length; i++)
{
    int divisores = 0;
    for (int j = 1; j <= vetor[i]; j++)
    {
        if (vetor[i] % j == 0)
        {
            divisores++;
        }
    }

    if (divisores == 2)
    {
        Console.WriteLine($"O valor {vetor[i]} é primo e está na posição {i}");
    }

}

