// 13.	Escreva um algoritmo para ler um vetor de inteiros e positivos e imprimir quantas vezes aparecem os números 2, 4 e 8. O vetor terá no máximo 100 posições. Sair do programa quando for digitado -1 ou quando atingir o máximo de posições do vetor.

Console.WriteLine($"Informe valores para o vetor. Digite -1 para sair:");

int[] vetor = new int[100];
int contador2 = 0;
int contador4 = 0;
int contador8 = 0;

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine()!);

    if (vetor[i] == -1)
    {
        break;
    }

    if (vetor[i] == 2)
    {
        contador2++;
    }
    else if (vetor[i] == 4)
    {
        contador4++;
    }
    else if (vetor[i] == 8)
    {
        contador8++;
    }
}

Console.WriteLine($"O vetor possui {contador2} números 2, {contador4} números 4 e {contador8} números 8.");
