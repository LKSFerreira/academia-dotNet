// 15) Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

Console.WriteLine($"Preencha a matriz com 4x4 de inteiros: ");
int[,] matrizPrimaria = new int[4, 4];
int[,] matrizSecundaria = new int[4, 4];
int[,] matrizResultante = new int[4, 4];

int linhaMatriz = matrizPrimaria.GetLength(0);
int colunaMatriz = matrizPrimaria.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz: ");
        matrizPrimaria[i, j] = random.Next(100);
        matrizSecundaria[i, j] = random.Next(100);
        matrizResultante[i, j] = matrizPrimaria[i, j] + matrizSecundaria[i, j];
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Matriz Primária: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.Write($"{matrizPrimaria[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"\n");

Console.WriteLine($"Matriz Secundária: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.Write($"{matrizSecundaria[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"\n");

Console.WriteLine($"Matriz Resultante das somas: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.Write($"{matrizResultante[i, j],+3} | ");
    }
    Console.WriteLine($"");
}
