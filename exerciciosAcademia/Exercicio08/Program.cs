// 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
// A fórmula da conversão é F=(9*C+160)/5.

Console.WriteLine($"Digite a temperatura em graus Celsius: ");
double temperaturaCelsius = double.Parse(Console.ReadLine()!);

double temperaturaFahrenheit = (9 * temperaturaCelsius + 160) / 5;

Console.WriteLine($"A temperatura em graus Fahrenheit é: {temperaturaFahrenheit.ToString("F2")}");