// Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.

Console.WriteLine($"Digite 10 números inteiros");
int length = 10;
int maiorNumero = 0;

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    int numero = int.Parse(Console.ReadLine()!);

    if (numero > maiorNumero)
    {
        maiorNumero = numero;
    }
}

Console.WriteLine($"O maior número digitado foi o {maiorNumero}");
