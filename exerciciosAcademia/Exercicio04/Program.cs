// 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
// forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

Console.WriteLine($"Digite a data no formato DDMMAAAA: ");
string data = Console.ReadLine()!;

string dia = data.Substring(0, 2);
string mes = data.Substring(2, 2);
string ano = data.Substring(4, 4);

Console.WriteLine($"A data no formato AAAAMMDD é: {ano}{mes}{dia}");

string anoReduzido = ano.Substring(2, 2);
Console.WriteLine($"A data no formato AAMMDD é: {anoReduzido}{mes}{dia}");