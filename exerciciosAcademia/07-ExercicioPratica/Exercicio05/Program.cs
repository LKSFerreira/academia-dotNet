// 5) Leia duas matrizes 2x3 de números double. 
// Imprima a soma destas duas matrizes.


Console.WriteLine($"Digite os elementos da primeira matriz 2x3: ");
double[,] matrizDouble1 = new double[2, 3];

int linhaMatrizDeDouble1 = matrizDouble1.GetLength(0);
int colunaMatrizDeDouble1 = matrizDouble1.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatrizDeDouble1; i++)
{
    for (int j = 0; j < colunaMatrizDeDouble1; j++)
    {
        Console.Write($"Digite o elemento [{i}, {j}]: ");
        matrizDouble1[i, j] = random.NextDouble() * 10;
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Digite os elementos da sgeunda matriz 2x3: ");
double[,] matrizDouble2 = new double[2, 3];

int linhaMatrizDeDouble2 = matrizDouble2.GetLength(0);
int colunaMatrizDeDouble2 = matrizDouble2.GetLength(1);

for (int i = 0; i < linhaMatrizDeDouble2; i++)
{
    for (int j = 0; j < colunaMatrizDeDouble2; j++)
    {
        Console.Write($"Digite o elemento [{i}, {j}]: ");
        matrizDouble2[i, j] = random.NextDouble() * 10;
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Somando as duas matrizes: ");
double[,] matrizDoubleSoma = new double[2, 3];

for (int i = 0; i < linhaMatrizDeDouble1; i++)
{
    for (int j = 0; j < colunaMatrizDeDouble1; j++)
    {
        matrizDoubleSoma[i, j] = matrizDouble1[i, j] + matrizDouble2[i, j];
    }
}

for (int i = 0; i < linhaMatrizDeDouble1; i++)
{
    for (int j = 0; j < colunaMatrizDeDouble1; j++)
    {
        Console.Write($"{matrizDoubleSoma[i, j].ToString("N2"),+5} | ");
    }
    Console.WriteLine($"");
}

