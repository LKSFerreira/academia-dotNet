// 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

Console.WriteLine($"Digite 3 valores separados por espaço");
string valores = Console.ReadLine()!;
string[] valoresSeparados = valores.Split();

int valor1 = int.Parse(valoresSeparados[0]);
int valor2 = int.Parse(valoresSeparados[1]);
int valor3 = int.Parse(valoresSeparados[2]);

int maiorValor = valor1 > valor2 ? valor1 : valor2;
maiorValor = maiorValor > valor3 ? maiorValor : valor3;

Console.WriteLine($"O maior valor é {maiorValor}");