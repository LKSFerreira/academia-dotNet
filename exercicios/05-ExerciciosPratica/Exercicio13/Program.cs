// 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
// entre 1 e 500.

int numeroMaximoParaSomaEmSequencia = 500;
int totalSoma = 0;

for (int i = 0; i < numeroMaximoParaSomaEmSequencia; i++)
{
    totalSoma = i % 2 == 0 ? totalSoma + i : totalSoma;
}

Console.WriteLine($"O total da soma entre 1 e 500 é {totalSoma}");
