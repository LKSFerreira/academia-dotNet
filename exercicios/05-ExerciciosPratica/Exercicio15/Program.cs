// 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem dizendo se ele está aprovado 
// ou reprovado, após ter calculado sua média ponderando, considerando pesos 2, 1, 2, e 4, respectivamente. 
// Considerar nota 7,0 como mínima para aprovação.

Console.WriteLine($"Digite a primeira nota: ");
double nota1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a segunda nota: ");
double nota2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a terceira nota: ");
double nota3 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a quarta nota: ");
double nota4 = double.Parse(Console.ReadLine()!);

int totalPesoDasNotas = 2 + 1 + 2 + 4;

double media = (nota1 * 2 + nota2 * 1 + nota3 * 2 + nota4 * 4) / totalPesoDasNotas;

if (media >= 7)
{
    Console.WriteLine($"O aluno está aprovado com média {media.ToString("N2")}");
}
else
{
    Console.WriteLine($"O aluno está reprovado com média {media.ToString("N2")}");
}
