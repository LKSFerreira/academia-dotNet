// 11) Leia uma matriz A de tipo double de dimenção 3x3, crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

Console.WriteLine($"Preencha a matriz A com 3x3 de double: ");
double[,] matrizA = new double[3, 3];

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

Console.WriteLine($"\n");

Console.WriteLine($"Matriz A: ");

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        Console.Write($"{matrizA[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

double[,] matrizResultante = new double[3, 3];

matrizResultante[0, 0] = double.NaN;

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        if (i == 0 && j == 0) continue;
        matrizResultante[i, j] = matrizA[i, j] / (i + j);
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Resultado da divisão dos elementos da matriz A pela soma dos seus indices: ");

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        Console.Write($"{matrizResultante[i, j].ToString("N2"),+5} | ");
    }
    Console.WriteLine($"");
}
