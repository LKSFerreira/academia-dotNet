// /7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
// o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
// Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

Console.WriteLine($"Digite o número do vendedor: ");
int numeroVendedor = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o salário fixo do vendedor: ");
double salarioFixo = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o total de vendas do vendedor: ");
double totalVendas = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o percentual que o vendedor ganha sobre o total de vendas: ");
double percentualVendas = double.Parse(Console.ReadLine()!);

double salarioTotal = salarioFixo + (totalVendas * (percentualVendas / 100));

Console.WriteLine($"O número do vendedor é: {numeroVendedor}");
Console.WriteLine($"O salário total do vendedor é: {salarioTotal.ToString("C2")}");