// 4) Popule uma matriz 5x5 e informe:
// -Quantos números são pares
// -Quantos números são impares
// -Quantos números são positivos
// -Quantos números são negativos
// -Quantos zeros existem!

Console.WriteLine($"Digite os elementos da matriz 5x5: ");
int[,] matrizInteiro = new int[5, 5];

int linhaMatrizDeInteiro = matrizInteiro.GetLength(0);
int colunaMatrizDeInteiro = matrizInteiro.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        matrizInteiro[i, j] = random.Next(-10, 10);
    }
}

Console.WriteLine($"");

Console.WriteLine($"Matriz preenchida: ");

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        Console.Write($"{matrizInteiro[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"");

int quantidadeDePares = 0;
int quantidadeDeImpares = 0;
int quantidadeDePositivos = 0;
int quantidadeDeNegativos = 0;

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        quantidadeDePares = matrizInteiro[i, j] % 2 == 0 ? quantidadeDePares + 1 : quantidadeDePares;
        quantidadeDeImpares = matrizInteiro[i, j] % 2 != 0 ? quantidadeDeImpares + 1 : quantidadeDeImpares;
        quantidadeDePositivos = matrizInteiro[i, j] > 0 ? quantidadeDePositivos + 1 : quantidadeDePositivos;
        quantidadeDeNegativos = matrizInteiro[i, j] < 0 ? quantidadeDeNegativos + 1 : quantidadeDeNegativos;
    }
}

Console.WriteLine($"Quantidade de números pares: {quantidadeDePares}");
Console.WriteLine($"Quantidade de números ímpares: {quantidadeDeImpares}");
Console.WriteLine($"Quantidade de números positivos: {quantidadeDePositivos}");
Console.WriteLine($"Quantidade de números negativos: {quantidadeDeNegativos}");

