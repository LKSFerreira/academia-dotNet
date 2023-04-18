// 14.	Escreva um algoritmo que leia um código numérico inteiro e um vetor de 50 posições de números. Se o código for zero, termine o algoritmo. Se o código for 1, mostre o vetor na ordem em que foi lido. Se o código for 2, mostre o vetor na ordem inversa, do último elemento até o primeiro.

Console.WriteLine($"Informe 50 valores para o vetor:");
int[] vetor = new int[5];

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);

    switch (vetor[i])
    {
        case 0:
            return;
        case 1:
            Console.WriteLine($"Vetor:");
            for (int j = 0; j < vetor.Length; j++)
            {
                Console.Write($"{vetor[j]} | ");
            }
            break;
        case 2:
            Console.WriteLine($"Vetor invertido:");
            for (int j = vetor.Length - 1; j >= 0; j--)
            {
                Console.Write($"{vetor[j]} | ");
            }
            break;
        default:
            Console.WriteLine($"Código inválido.");
            break;
    }
}
