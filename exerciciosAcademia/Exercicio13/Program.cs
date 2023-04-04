// 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
// preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
// vendidas pelo vendedor, calcule e mostre: o salário do empregado

Console.WriteLine($"Digite o valor do salário mínimo: ");
double valorSalarioMinimo = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o preço de custo de cada bicicleta: ");
double precoCustoBicicleta = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número de bicicletas vendidas pelo vendedor: ");
int numeroBicicletasVendidas = int.Parse(Console.ReadLine()!);

double salarioEmpregado = (valorSalarioMinimo * 2) + (precoCustoBicicleta * 0.15);

Console.WriteLine($"O salário do empregado é: {salarioEmpregado.ToString("C")}");