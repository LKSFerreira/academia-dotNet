// 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
// isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
// de IPI (única) a ser acrescentada. 

// O programa deve calcular e imprimir o valor total de cada parafuso e o valor total da nota fiscal

Console.WriteLine($"Digite a quantidade de parafusos A: ");
int quantidadeParafusosA = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor unitário do parafuso A: ");
double valorUnitarioParafusoA = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a porcentagem de IPI do parafuso A: ");
double porcentagemIpiParafusoA = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a quantidade de parafusos B: ");
int quantidadeParafusosB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor unitário do parafuso B: ");
double valorUnitarioParafusoB = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a porcentagem de IPI do parafuso B: ");
double porcentagemIpiParafusoB = double.Parse(Console.ReadLine()!);

double valorTotalParafusoA = (quantidadeParafusosA * valorUnitarioParafusoA);
double valorTotalParafusoAComIpi = valorTotalParafusoA + (valorTotalParafusoA * (porcentagemIpiParafusoA / 100));

double valorTotalParafusoB = quantidadeParafusosB * valorUnitarioParafusoB;
double valorTotalParafusoBComIpi = valorTotalParafusoB + (valorTotalParafusoB * (porcentagemIpiParafusoB / 100));

double valorTotalNotaFiscalComIpi = valorTotalParafusoAComIpi + valorTotalParafusoBComIpi;

Console.WriteLine($"O valor total do parafuso A é: {valorTotalParafusoA}");
Console.WriteLine($"O valor total do parafuso B é: {valorTotalParafusoB}");

Console.WriteLine($"=============================================");
Console.WriteLine($"O valor total da nota fiscal com IPI é: {valorTotalNotaFiscalComIpi}");
Console.WriteLine($"=============================================");
