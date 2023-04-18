// 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
// da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados 
// e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00. 
// Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

Console.WriteLine($"Digite o tamanho da área a ser pintada em metros quadrados");
double tamanhoArea = double.Parse(Console.ReadLine()!);

double precoLataTinta = 80.00;

double litrosTinta = tamanhoArea / 3;
double latasTinta = Math.Ceiling(litrosTinta / 18);
double precoTotal = latasTinta * precoLataTinta;

Console.WriteLine($"A quantidade de latas de tinta a serem compradas é: {latasTinta}");
Console.WriteLine($"O preço total é: {precoTotal.ToString("C")}");