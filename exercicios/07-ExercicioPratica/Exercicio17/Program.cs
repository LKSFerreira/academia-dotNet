// 17) Desafio: Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax, ou seja,o menor elemento da linha onde se encontra o 
// maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

Console.WriteLine($"Preencha a matriz com 10x10 de inteiros: ");

int[,] matriz = new int[10, 10];

int linhaMatriz = matriz.GetLength(0);
int colunaMatriz = matriz.GetLength(1);

Random random = new Random();

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz: ");
        matriz[i, j] = random.Next(-100, 100);
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Matriz: ");

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        Console.Write($"{matriz[i, j],+4} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"\n");

int maiorElemento = 0;
int linhaMaiorElemento = 0;
int colunaMaiorElemento = 0;
int menorElemento = 0;

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        if (matriz[i, j] > maiorElemento)
        {
            maiorElemento = matriz[i, j];
            linhaMaiorElemento = i;
            colunaMaiorElemento = j;

            menorElemento = matriz[linhaMaiorElemento, 0];

            for (int k = 0; k < colunaMatriz; k++)
            {
                menorElemento = matriz[linhaMaiorElemento, k] < menorElemento ? matriz[linhaMaiorElemento, k] : menorElemento;
            }

        }
    }
}

Console.WriteLine($"Maior elemento: {maiorElemento}");
Console.WriteLine($"Linha do maior elemento: {linhaMaiorElemento}");
Console.WriteLine($"Coluna do maior elemento: {colunaMaiorElemento}");
Console.WriteLine($"Menor elemento da linha do maior elemento: {menorElemento}");

