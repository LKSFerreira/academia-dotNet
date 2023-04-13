// 6.	Fazer um algoritmo que leia dez números e escreva-os na ordem contrária à ordem de leitura. Exemplo:
// a.	lê: 		|7|40|3|9|21|0|63|31|7|22|
// b.	escreve: 	|22|7|31|63|0|21|9|3|40|7|

Console.WriteLine($"Informe 10 valores para o vetor:");
int[] vetor = new int[10];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);
}

for (int i = vetor.Length - 1; i >= 0; i--)
{
    Console.Write($"{vetor[i]}|");
}
