// 14) Escreva um programa que leia uma matriz de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
// são os mesmos da diagonal 
// secundária (direita pra esquerda).

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

Console.WriteLine($"ELementos da diagonal principal: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        if (i == j)
        {
            Console.Write($"{matriz[i, j],+3} | ");
        }
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"ELementos da diagonal secundária: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        if (i + j == linhaMatriz - 1)
        {
            Console.Write($"{matriz[i, j],+3} | ");
        }
    }
}

