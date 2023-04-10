//Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x
// elevado na y sem utilizar a função pow.

Console.WriteLine($"Digite um valor inteiro para a base");
int valorBase = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite um valor inteiro para o expoente");
int valorPotencia = int.Parse(Console.ReadLine()!);

int resultadoPotencia = 1;

for (int i = 0; i < valorPotencia; i++)
{
    resultadoPotencia *= valorBase;
}

Console.WriteLine($"{valorBase} elevado a {valorPotencia} é {resultadoPotencia}");
