// 6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0-9. Após isso determine o maior número da matriz.
// Random random = new Random();
// int randomNumber = random.Next(0, 100);

Console.WriteLine($"Matriz aleatória 4x4: ");
int[,] matrizAleatoria = new int[4, 4];
int linhaMatrizAleatoria = matrizAleatoria.GetLength(0);
int colunaMatrizAleatoria = matrizAleatoria.GetLength(1);

Random random = new Random();

int maiorNumero = 0;

for (int i = 0; i < linhaMatrizAleatoria; i++)
{
    for (int j = 0; j < colunaMatrizAleatoria; j++)
    {
        matrizAleatoria[i, j] = random.Next(100);
        maiorNumero = matrizAleatoria[i, j] > maiorNumero ? matrizAleatoria[i, j] : maiorNumero;
    }
}

for (int i = 0; i < linhaMatrizAleatoria; i++)
{
    for (int j = 0; j < colunaMatrizAleatoria; j++)
    {
        Console.Write($"{matrizAleatoria[i, j],+3} | ");
    }
    Console.WriteLine($"");
}
Console.WriteLine($"");

Console.WriteLine($"O maior número da matriz é: {maiorNumero}");
