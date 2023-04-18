// 12) Escreva um programa que leia os valores de uma matriz 4x3, e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

Console.WriteLine($"Preencha a matriz com 4x3 de inteiros: ");
int[,] matriz = new int[4, 3];

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

Console.WriteLine($"Valores cuja soma dos índices (i+j) seja um número par: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        if ((i + j) % 2 == 0)
        {
            Console.Write($"{matriz[i, j],+3} | ");
        }
    }
}
