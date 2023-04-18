// 9) Leia uma matriz 3x3.  Em seguida, solicite um número qualquer ao usuário e pesquise na matriz se o número existe.  
// Caso, seja verdade imprima a mensagem:  “O número existe no vetor” , caso contrário “Número inexistente”.

Console.WriteLine($"Preencha a matriz com 3x3 de inteiros: ");
int[,] matriz = new int[3, 3];

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

Console.WriteLine($"Digite uma número para pesquisar na matriz: ");
int numero = int.Parse(Console.ReadLine()!);
bool numeroExiste = false;

for (int i = 0; i < linhaMatriz; i++)
{
    for (int j = 0; j < colunaMatriz; j++)
    {
        if (matriz[i, j] == numero)
        {
            Console.WriteLine($"\nO número {numero} existe na matriz.");
            return;
        }
    }
}

if (!numeroExiste) Console.WriteLine($"O número {numero} não existe na matriz.");