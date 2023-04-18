// Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
// um usuário. Apresente o resultado.

Console.WriteLine($"Digite 20 números: ");
int qtdNumeros = 5;
int qtdPares = 0;
int qtdImpares = 0;

for (int i = 0; i < qtdNumeros; i++)
{
    int numero = int.Parse(Console.ReadLine()!);

    if (numero == 0 || numero % 2 == 0)
    {
        qtdPares++;
    }
    else
    {
        qtdImpares++;
    }
}

Console.WriteLine($"A quantidade de números pares é {qtdPares}");
Console.WriteLine($"A quantidade de números ímpares é {qtdImpares}");
