// •Dados três números, verificar se eles podem representar as medidas dos lados de um triângulo e, classificar o triângulo em equilátero, isósceles ou escaleno.
// •
// •Para que três números representem os lados de um triângulo é necessário que cada um deles seja menor que a soma dos outros dois.
// •
// •Um triângulo é equilátero se tem os três lados iguais,  isósceles se tem apenas dois lados iguais e escaleno se tem todos os lados distintos.

Console.WriteLine($"Digite o primeiro lado do triângulo: ");
double lado1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o segundo lado do triângulo: ");
double lado2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o terceiro lado do triângulo: ");
double lado3 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"");

if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
{
    Console.WriteLine("Os lados formam um triângulo");

    if (lado1 == lado2 && lado2 == lado3)
    {
        Console.WriteLine("O triângulo é equilátero");
    }
    else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
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
    Console.WriteLine("Os lados não formam um triângulo");
}
