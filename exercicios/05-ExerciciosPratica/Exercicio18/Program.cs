// 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
// elevada a um expoente qualquer, ou seja, NM.

Console.WriteLine($"Digite a base da potência: ");
int basePotencia = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o expoente da potência: ");
int expoentePotencia = int.Parse(Console.ReadLine()!);

int resultado = (int)Math.Pow(basePotencia, expoentePotencia);

Console.WriteLine($"{basePotencia}^{expoentePotencia} = {resultado}");
