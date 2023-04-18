// 8) Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e inversa a que foram lidos.

Console.WriteLine($"Preencha a matriz com 4x4 de inteiros: ");
int[,] matriz = new int[4, 4];

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

Console.WriteLine($"Matriz na ordem inversa: ");

for (int i = linhaMatriz - 1; i >= 0; i--)
{
    for (int j = colunaMatriz - 1; j >= 0; j--)
    {
        Console.Write($"{matriz[i, j],+3} | ");
    }
    Console.WriteLine($"");
}
