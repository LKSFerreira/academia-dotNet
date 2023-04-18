// 13 - Tendo como dado de entrada a altura (h) de uma pessoa, construa um programa no VS que calcule 
// seu peso ideal, utilizando as seguintes fórmulas:
// Para homens: (72.7 * h) - 58
// Para mulheres: (62.1 * h) - 44.7

Console.WriteLine($"Digite a altura");
double altura = double.Parse(Console.ReadLine()!);

double pesoIdealHomem = (72.7 * altura) - 58;
double pesoIdealMulher = (62.1 * altura) - 44.7;

Console.WriteLine($"O peso ideal para homens é: {pesoIdealHomem.ToString("F2")}");
Console.WriteLine($"O peso ideal para mulheres é: {pesoIdealMulher.ToString("F2")}");
