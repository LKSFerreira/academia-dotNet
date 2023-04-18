// 1) Crie uma Matriz 5x3. Na primeira coluna, solicite que o usuário preencha. A 2ª coluna, some 10 aos elementos da 1ª coluna. Na 3º coluna, armazene o dobro dos elementos da 1ª coluna.

int[,] matrizInteiro = new int[5, 3];

int linhaMatrizDeInteiro = matrizInteiro.GetLength(0);
int colunaMatrizDeInteiro = matrizInteiro.GetLength(1);

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    Console.Write("Digite um número: ");
    matrizInteiro[i, 0] = int.Parse(Console.ReadLine()!);

    matrizInteiro[i, 1] = matrizInteiro[i, 0] + 10;
    matrizInteiro[i, 2] = matrizInteiro[i, 0] * 2;
}

Console.WriteLine("Matriz preenchida: ");

for (int i = 0; i < linhaMatrizDeInteiro; i++)
{
    for (int j = 0; j < colunaMatrizDeInteiro; j++)
    {
        Console.Write($"{matrizInteiro[i, j]} | ");
    }
    Console.WriteLine($"");
}
