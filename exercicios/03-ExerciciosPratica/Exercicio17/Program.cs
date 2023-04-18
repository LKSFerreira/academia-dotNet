// 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), e então diga se esses lados podem ou não formar um triangulo. Para que os lados
// formem um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos
// os lados iguais), isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes).

Console.WriteLine($"Digite o tamanho dos lados do triângulo");
string lados = Console.ReadLine()!;
string[] ladosSeparados = lados.Split();
int ladoA = int.Parse(ladosSeparados[0]);
int ladoB = int.Parse(ladosSeparados[1]);
int ladoC = int.Parse(ladosSeparados[2]);

bool podeFormarTriangulo = ladoA <= ladoB + ladoC && ladoB <= ladoA + ladoC && ladoC <= ladoA + ladoB;

if (podeFormarTriangulo)
{
    if (ladoA == ladoB && ladoB == ladoC)
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if (ladoA == ladoB || ladoB == ladoC || ladoA == ladoC)
    {
        Console.WriteLine("O triângulo é isósceles");
    }
    else
    {
        Console.WriteLine("O triângulo é escaleno");
    }
}
else
{
    Console.WriteLine("Não é possível formar um triângulo com esses lados");
}
