// 13) Escreva um programa que leia uma matriz de ordem 5 (ou seja, 5x5) e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da 
// diagonal secundária.

Console.WriteLine($"Preencha a matriz com 5x5 de inteiros: ");

int[,] matriz = new int[5, 5];

int linhaMatriz = matriz.GetLength(0);
int colunaMatriz = matriz.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz: ");
        matriz[i, j] = random.Next(100);
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Matriz: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.Write($"{matriz[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"\n");

int somaDiagonalPrincipal = 0;
int somaDiagonalSecundaria = 0;

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        somaDiagonalPrincipal += i == j ? matriz[i, j] : 0;
        somaDiagonalSecundaria += i + j == linhaMatriz - 1 ? matriz[i, j] : 0;
    }
}

Console.WriteLine($"Soma da diagonal principal: {somaDiagonalPrincipal}");
Console.WriteLine($"Soma da diagonal secundária: {somaDiagonalSecundaria}");
