// 10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

Console.WriteLine($"Preencha a matriz A com 4x4 de inteiros: ");
int[,] matrizA = new int[4, 4];

int linhaMatrizA = matrizA.GetLength(0);
int colunaMatrizA = matrizA.GetLength(1);

Random random = new Random();

int somatoriaDasMatrizes = 0;

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz A: ");
        matrizA[i, j] = random.Next(100);
        somatoriaDasMatrizes += matrizA[i, j];
    }
}

Console.WriteLine($"\n");

Console.WriteLine($"Preencha a matriz B com 4x4 de inteiros: ");
int[,] matrizB = new int[4, 4];

int linhaMatrizB = matrizB.GetLength(0);
int colunaMatrizB = matrizB.GetLength(1);

for (int i = 0; i < linhaMatrizB; i++)
{
    for (int j = 0; j < colunaMatrizB; j++)
    {
        Console.WriteLine($"Digite o valor da linha {i + 1} e coluna {j + 1} da matriz B: ");
        matrizB[i, j] = random.Next(100);
        somatoriaDasMatrizes += matrizB[i, j];
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

Console.WriteLine($"\n");

Console.WriteLine($"Matriz B: ");

for (int i = 0; i < linhaMatrizB; i++)
{
    for (int j = 0; j < colunaMatrizB; j++)
    {
        Console.Write($"{matrizB[i, j],+3} | ");
    }
    Console.WriteLine($"");
}

Console.WriteLine($"\n");

double mediaDasMatrizes = somatoriaDasMatrizes / (matrizA.Length + matrizB.Length);

Console.WriteLine($"A média das matrizes é: {mediaDasMatrizes}");

int quantidadeDeElementosAcimaDaMedia = 0;
int quantidadeDeElementosAbaixoDaMedia = 0;

for (int i = 0; i < linhaMatrizA; i++)
{
    for (int j = 0; j < colunaMatrizA; j++)
    {
        quantidadeDeElementosAbaixoDaMedia += matrizA[i, j] < mediaDasMatrizes ? 1 : 0;
        quantidadeDeElementosAcimaDaMedia += matrizA[i, j] > mediaDasMatrizes ? 1 : 0;

        quantidadeDeElementosAbaixoDaMedia += matrizB[i, j] < mediaDasMatrizes ? 1 : 0;
        quantidadeDeElementosAcimaDaMedia += matrizB[i, j] > mediaDasMatrizes ? 1 : 0;
        
    }
}

Console.WriteLine($"A quantidade de elementos abaixo da média é: {quantidadeDeElementosAbaixoDaMedia}");
Console.WriteLine($"A quantidade de elementos acima da média é: {quantidadeDeElementosAcimaDaMedia}");
