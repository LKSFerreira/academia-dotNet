// 16.	Escreva um algoritmo que leia 2 vetores X[10] e Y[10] e os escreva. Crie, a seguir, um vetor para cada uma das operações:
// •	A união de X com Y
// •	A diferença entre X e Y
// •	A interseção entre X e Y
// Escreva o vetor resultado de cada uma das operações.

Console.WriteLine($"Informe 10 valores para o vetor 1:");
int[] vetorX = new int[10];

for (int i = 0; i < vetorX.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorX[i] = int.Parse(Console.ReadLine()!);
}

Console.WriteLine($"Informe 10 valores para o vetor 2:");
int[] vetorY = new int[10];

for (int i = 0; i < vetorY.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetorY[i] = int.Parse(Console.ReadLine()!);
}

int[] uniaoDosVetores = new int[vetorX.Length+vetorY.Length];
int[] vetorDosValoresQueExistemEmYMasNaoEmX = new int[vetorY.Length];
int[] vetorDosValoresQuePussemNoXeNoY = new int[vetorX.Length+vetorY.Length];

Console.WriteLine($"União dos vetores X e Y:");
for (int i = 0; i < vetorX.Length; i++)
{
    uniaoDosVetores[i] = vetorX[i];
}

for (int i = 0; i < vetorY.Length; i++)
{
    uniaoDosVetores[i+vetorX.Length] = vetorY[i];
}

for (int i = 0; i < uniaoDosVetores.Length; i++)
{
    Console.Write($"{uniaoDosVetores[i]} | ");
}

Console.WriteLine($"");

Console.WriteLine($"Diferença entre os vetores X e Y:");

int contador = 0;

for (int i = 0; i < vetorY.Length; i++)
{
    bool existeNaLista = false;
    for (int j = 0; j < vetorX.Length; j++)
    {
        if (vetorY[i] == vetorX[j])
        {
            existeNaLista = true;
        }
    }

    if (!existeNaLista)
    {
        vetorDosValoresQueExistemEmYMasNaoEmX[contador] = vetorY[i];
        contador++;
    }
}

for (int i = 0; i < vetorDosValoresQueExistemEmYMasNaoEmX.Length; i++)
{
    Console.Write($"{vetorDosValoresQueExistemEmYMasNaoEmX[i]} | ");
}

Console.WriteLine($"");

Console.WriteLine($"Interseção entre os vetores X e Y:");

contador = 0;

for (int i = 0; i < vetorY.Length; i++)
{
    bool existeNaLista = false;
    for (int j = 0; j < vetorX.Length; j++)
    {
        if (vetorY[i] == vetorX[j])
        {
            existeNaLista = true;
        }
    }

    if (existeNaLista)
    {
        vetorDosValoresQuePussemNoXeNoY[contador] = vetorY[i];
        contador++;
    }
}

for (int i = 0; i < vetorDosValoresQuePussemNoXeNoY.Length; i++)
{
    Console.Write($"{vetorDosValoresQuePussemNoXeNoY[i]} | ");
}
