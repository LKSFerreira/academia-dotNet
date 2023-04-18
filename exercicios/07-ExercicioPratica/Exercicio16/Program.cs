// 16) Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3. Transpor uma matriz significa transformar suas linhas em colunas e vice-versa.

Console.WriteLine($"Preencha a matriz com 3x4 de inteiros: ");
int[,] matriz = new int[3, 4];

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

Console.WriteLine($"Matriz transposta: ");

for (int i = 0; i < colunaMatriz; i++)
{
    for (int j = 0; j < linhaMatriz; j++)
    {
        Console.Write($"{matriz[j, i],+3} | ");
    }
    Console.WriteLine($"");
}

