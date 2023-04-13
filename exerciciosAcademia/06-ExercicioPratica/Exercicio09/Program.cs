// 9.	Escreva um algoritmo que leia os valores para um vetor de 10 elementos, e em seguida ordene em ordem crescente os valores desse vetor, utilizando um vetor auxiliar.

Console.WriteLine($"Informe 10 valores para o vetor:");
int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

int[] vetorAuxiliar = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    vetorAuxiliar[i] = vetor[i];
}

for (int i = 0; i < vetorAuxiliar.Length; i++)
{
    for (int j = 0; j < vetorAuxiliar.Length; j++)
    {
        if (vetorAuxiliar[i] < vetorAuxiliar[j])
        {
            int aux = vetorAuxiliar[i];
            vetorAuxiliar[i] = vetorAuxiliar[j];
            vetorAuxiliar[j] = aux;
        }
    }
}

Console.WriteLine($"Vetor ordenado:");
for (int i = 0; i < vetorAuxiliar.Length; i++)
{
    Console.WriteLine(vetorAuxiliar[i]);
}
