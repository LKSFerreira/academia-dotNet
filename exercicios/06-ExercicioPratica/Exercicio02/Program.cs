// 2.	Escreva um algoritmo que leia valores para dois vetores de 20 elementos e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

Console.WriteLine($"Informe 20 valores para o vetor 1:");
int[] vetorCom20Posicoes = new int[20];
for (int i = 0; i < vetorCom20Posicoes.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorCom20Posicoes[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Informe 20 valores para o vetor 2:");
int[] vetorCom20Posicoes2 = new int[20];
for (int i = 0; i < vetorCom20Posicoes2.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorCom20Posicoes2[i] = int.Parse(Console.ReadLine()!);
}

int[] vetorCom20Posicoes3 = new int[20];
for (int i = 0; i < vetorCom20Posicoes3.Length; i++)
{
    vetorCom20Posicoes3[i] = vetorCom20Posicoes[i] + vetorCom20Posicoes2[i];
    Console.WriteLine($"A soma dos valores da posição {i} é: {vetorCom20Posicoes3[i]}");
}
