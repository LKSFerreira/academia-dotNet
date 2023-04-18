// 7.	Fazer um algoritmo que leia dez números inteiros armazenando-os em um vetor e escreva primeiramente todos os números pares lidos e após todos os ímpares. Exemplo:
// a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
// b.	escreve: 	|40|0|22|7|3|9|21|63|31|7|

Console.WriteLine($"Informe 10 valores para o vetor:");
int[] vetor = new int[10];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

int[] pares = new int[10];
int[] impares = new int[10];

int posicaoPares = 0;
int posicaoImpares = 0;

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] % 2 == 0)
    {
        pares[posicaoPares] = vetor[i];
        posicaoPares++;
    }
    else
    {
        impares[posicaoImpares] = vetor[i];
        posicaoImpares++;
    }
}

Console.WriteLine($"\nOs números pares são:");
for (int i = 0; i < posicaoPares; i++)
{
    Console.Write($"{pares[i]}|");
}
Console.WriteLine($"");

Console.WriteLine($"\nOs números ímpares são:");
for (int i = 0; i < posicaoImpares; i++)
{
    Console.Write($"{impares[i]}|");
}

Console.WriteLine($"");