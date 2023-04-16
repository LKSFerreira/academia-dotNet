// 3) Popule uma matriz 4x4 e mostre os elementos da Diagonal Principal!

int[,] matrizInteiro = new int[4, 4];

int linhaMatrizDeInteiro = matrizInteiro.GetLength(0);
int colunaMatrizDeInteiro = matrizInteiro.GetLength(1);

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        Console.Write($"Digite o elemento [{i}, {j}]: ");
        matrizInteiro[i, j] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine($"");

Console.WriteLine($"Diagonal Principal: ");
for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        if (i == j)
        {
            Console.Write($"{matrizInteiro[i, j]} | ");
        }
    }
}