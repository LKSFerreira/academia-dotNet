//Escreva um algoritmo para calcular o fatorial de um número.

Console.WriteLine($"Digite um valor inteiro");
int valorX = int.Parse(Console.ReadLine()!);

int fatorial = 1;

for (int i = 1; i <= valorX; i++)
{
    fatorial *= i;
}

Console.WriteLine($"O fatorial de {valorX} é {fatorial}");