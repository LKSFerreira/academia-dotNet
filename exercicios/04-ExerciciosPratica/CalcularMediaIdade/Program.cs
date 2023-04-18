// Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado calcular a média de idade de n pessoas.

Console.WriteLine($"Deseja calcular a média de idade de quantas pessoas?");
int numeroN = int.Parse(Console.ReadLine()!);

int somaIdade = 0;

for (int i = 0; i < numeroN; i++)
{
    Console.WriteLine($"Digite a idade da pessoa {i + 1}");
    int idade = int.Parse(Console.ReadLine()!);
    somaIdade += idade;
}

double mediaIdade = (double)somaIdade / numeroN;
Console.WriteLine($"A média de idade das {numeroN} pessoas é {mediaIdade}");