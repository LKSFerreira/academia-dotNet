// 7) Leia duas matrizes A e B com 3x3 elementos. Construir uma matriz C, onde cada elemento de C é a subtração do elemento correspondente de A com B.

Console.WriteLine($"Matriz A: ");
int[,] matrizA = new int[3, 3];

int linhaMatrizA = matrizA.GetLength(0);
int colunaMatrizA = matrizA.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz A: ");
        matrizA[i, j] = random.Next(100);
    }
}

Console.WriteLine($"");
Console.WriteLine($"Matriz B: ");

int[,] matrizB = new int[3, 3];

int linhaMatrizB = matrizB.GetLength(0);
int colunaMatrizB = matrizB.GetLength(1);

for (int i = 0; i < linhaMatrizB; i++)
{
    for (int j = 0; j < colunaMatrizB; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz B: ");
        matrizB[i, j] = random.Next(100);
    }
}

Console.WriteLine($"\n");

int[,] matrizC = new int[3, 3];

int linhaMatrizC = matrizC.GetLength(0);
int colunaMatrizC = matrizC.GetLength(1);

for (int i = 0; i < linhaMatrizC; i++)
{
    for (int j = 0; j < colunaMatrizC; j++)
    {
        matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
    }
}

Console.WriteLine($"Matriz C: ");

for (int i = 0; i < linhaMatrizC; i++)
{
    for (int j = 0; j < colunaMatrizC; j++)
    {
        Console.Write($"{matrizC[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

