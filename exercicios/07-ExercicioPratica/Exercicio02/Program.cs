// 2) Solicite ao usuário, preencher uma Matriz 3x3

// Informe ao usuário:
// *A soma dos elementos de cada linha
// 	-Ex: Linha 1: 30
// 	     Linha 2: 17
// *A soma dos elementos de cada coluna
// 	-Ex: Coluna 1: 23
// 	     Coluna 2: 36

Console.WriteLine($"Digite os elementos da matriz 3x3: ");
int[,] matrizInteiro = new int[3, 3];

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

Console.WriteLine($"Soma dos elementos de cada linha: ");
for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    int soma = 0;
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        soma += matrizInteiro[i, j];
    }
    Console.WriteLine($"Total {i}: {soma}");
}

Console.WriteLine($"");

Console.WriteLine($"Soma dos elementos de cada coluna: ");
for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    int soma = 0;
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        soma += matrizInteiro[j, i];
    }
    Console.WriteLine($"Coluna {i}: {soma}");
}

