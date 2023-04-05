// 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas por dois professores e o valor por hora recebido por cada um deles. 
// Mostrar na tela qual dos professores tem o maior salário total.

Console.WriteLine($"Digite a quantidade de horas aula dadas pelo professor 1: ");
int horasAulaProfessor1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o valor por hora recebido pelo professor 1: ");
double valorHoraProfessor1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a quantidade de horas aula dadas pelo professor 2: ");
int horasAulaProfessor2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite o valor por hora recebido pelo professor 2: ");
double valorHoraProfessor2 = double.Parse(Console.ReadLine()!);

double salarioProfessor1 = horasAulaProfessor1 * valorHoraProfessor1;
double salarioProfessor2 = horasAulaProfessor2 * valorHoraProfessor2;

if (salarioProfessor1 > salarioProfessor2)
{
    Console.WriteLine($"O professor 1 tem o maior salário total.");
}
else if (salarioProfessor1 < salarioProfessor2)
{
    Console.WriteLine($"O professor 2 tem o maior salário total.");
}
else
{
    Console.WriteLine($"Os professores 1 e 2 tem o mesmo salário total.");
}