// 4.	Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação dos elementos de mesmo índice, colocando o resultado em um terceiro vetor. Mostre o vetor resultante.

Console.WriteLine($"Informe 10 valores para o vetor 1:");
int[] vetorCom10Posicoes = new int[10];

for (int i = 0; i < vetorCom10Posicoes.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorCom10Posicoes[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Informe 10 valores para o vetor 2:");
int[] vetorCom10Posicoes2 = new int[10];

for (int i = 0; i < vetorCom10Posicoes2.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorCom10Posicoes2[i] = int.Parse(Console.ReadLine()!);
}

int[] vetorCom10Posicoes3 = new int[10];

for (int i = 0; i < vetorCom10Posicoes3.Length; i++)
{
    vetorCom10Posicoes3[i] = vetorCom10Posicoes[i] * vetorCom10Posicoes2[i];
    Console.WriteLine($"A multiplicação dos valores da posição {i} é: {vetorCom10Posicoes3[i]}");
}