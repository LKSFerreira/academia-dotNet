// 11 - Faça um programa no VS que receba uma hora, dividida em 2 variáveis (uma para hora e outra para minutos).
// O programa deve exibir se a hora digitada está ou não válida. 
// Lembre que usaremos o padrão de hora com 24h, de 0 a 23.

Console.WriteLine($"Digite o horário");
string horario = Console.ReadLine()!;
string[] horarioSeparado = horario.Split(':');
int hora = int.Parse(horarioSeparado[0]);
int minuto = int.Parse(horarioSeparado[1]);

if (hora >= 0 && hora <= 23 && minuto >= 0 && minuto <= 59)
{
    Console.WriteLine($"Horário válido");
}
else
{
    Console.WriteLine($"Horário inválido");
}