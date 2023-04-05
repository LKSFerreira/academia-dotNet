// 12) Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
// marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido 
// dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.

// Fórmulas: Total quilometragem =  marcação odômetro final do dia - marcação odômetro inicio do dia 

// Média do consumo = Total quilometragem/ quantidade de combustível gasto

// Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

Console.WriteLine("Digite a marcação do odômetro no início do dia: ");
int marcacaoOdometroInicio = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a marcação do odômetro no final do dia: ");
int marcacaoOdometroFinal = int.Parse(Console.ReadLine()!);

Console.WriteLine("Digite a quantidade de litros de combustível gasto: ");
double quantidadeLitrosCombustivel = double.Parse(Console.ReadLine()!);

Console.WriteLine("Digite o valor total recebido dos passageiros: ");
double valorTotalRecebido = double.Parse(Console.ReadLine()!);

double totalQuilometragem = marcacaoOdometroFinal - marcacaoOdometroInicio;
double mediaConsumo = totalQuilometragem / quantidadeLitrosCombustivel;
double lucroDia = valorTotalRecebido - (quantidadeLitrosCombustivel * 6.90);

Console.WriteLine($"A média do consumo é: {mediaConsumo.ToString("F2")} Km/l");
Console.WriteLine($"O lucro do dia é: {lucroDia.ToString("C2")}");
