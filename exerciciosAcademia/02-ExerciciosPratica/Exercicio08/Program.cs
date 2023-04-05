// 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas de um funcionário.
// Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu salário final 5% do total de vendas.
// Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu salário final 7% do total de vendas.
// E por fim, se o total de vendas seja maior que R$ 5000,00, adicionar ao seu salário final 10% do 
// total de vendas. 

Console.WriteLine($"Digite o código do funcionário: ");
int codigo = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o nome do funcionário: ");
string nome = Console.ReadLine()!;

Console.WriteLine($"Digite o salário base do funcionário: ");
double salarioBase = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o total de vendas do funcionário: ");
double totalVendas = double.Parse(Console.ReadLine()!);
