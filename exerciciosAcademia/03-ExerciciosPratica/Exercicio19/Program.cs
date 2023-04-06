// 19 - Ajuste o exercício 18 de maneira que mostre os valores informados em ordem crescente.

Console.WriteLine($"Digite 3 valores separados por espaço");
string valores = Console.ReadLine()!;
string[] valoresSeparados = valores.Split();

int valor1 = int.Parse(valoresSeparados[0]);
int valor2 = int.Parse(valoresSeparados[1]);
int valor3 = int.Parse(valoresSeparados[2]);

int maiorValor = valor1 > valor2 ? valor1 : valor2;
maiorValor = maiorValor > valor3 ? maiorValor : valor3;

int menorValor = valor1 < valor2 ? valor1 : valor2;
menorValor = menorValor < valor3 ? menorValor : valor3;

int valorDoMeio = valor1 != maiorValor && valor1 != menorValor ? valor1 : valor2 != maiorValor && valor2 != menorValor ? valor2 : valor3;

Console.WriteLine($"Os valores em ordem crescente são {menorValor}, {valorDoMeio} e {maiorValor}");
