// 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
// coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 

// a) média do salário da população;
// b) média do número de filhos;
// c) maior salário;
// d) percentual de pessoas com salário até R$ 100,00.
// O final da leitura de dados se dará com a entrada de um salário negativo.

int numeroDePessoas = 0;
double somaSalarios = 0;
int somaDosFilhos = 0;
double mediaNumeroDeFilhos = 0;
double maiorSalario = 0;
int salarioAte100 = 0;



do
{
    Console.WriteLine($"Digite o salário: ");
    double salario = double.Parse(Console.ReadLine()!);

    if (salario < 0) break;

    salarioAte100 += salario <= 100 ? 1 : 0;

    maiorSalario = Math.Max(salario, maiorSalario);

    Console.WriteLine($"Digite o número de filhos: ");
    int numeroDeFilhos = int.Parse(Console.ReadLine()!);

    somaSalarios += salario;
    somaDosFilhos += numeroDeFilhos;
    numeroDePessoas++;


} while (true);

double mediaSalario = somaSalarios / numeroDePessoas;
mediaNumeroDeFilhos = somaDosFilhos / numeroDePessoas;
double percentualSalarioAte100 = (double)salarioAte100 / numeroDePessoas * 100;

Console.WriteLine($"A média do salário da população é: {mediaSalario.ToString("C")}");
Console.WriteLine($"A média do número de filhos é: {mediaNumeroDeFilhos.ToString("N2")}");
Console.WriteLine($"O maior salário é: {maiorSalario.ToString("C")}");
Console.WriteLine($"O percentual de pessoas com salário até R$ 100,00 é: {percentualSalarioAte100}%");
