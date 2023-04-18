// 1.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos e então mostre na tela a quantidade de números pares e ímpares.
Console.WriteLine($"Informe 10 valores para o vetor:");
int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

int pares = 0;
int impares = 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 == 0)
    {
        pares++;
    }
    else
    {
        impares++;
    }
}

Console.WriteLine($"O vetor possui {pares} números pares e {impares} números ímpares.");
