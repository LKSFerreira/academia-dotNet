// 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
// a média aritmética da turma e a quantidade de alunos da turma. Usar -1 para encerrar a leitura.

double notaMaisAlta = 0;
double notaMaisBaixa = 0;
double somaDasNotas = 0;
int quantidadeAlunos = 0;

do
{
    Console.WriteLine($"Digite a nota do aluno {quantidadeAlunos + 1}: ");
    double nota = double.Parse(Console.ReadLine()!);

    if (nota == -1)
    {
        break;
    }

    if (quantidadeAlunos == 0)
    {
        notaMaisAlta = nota;
        notaMaisBaixa = nota;
    }
    else
    {
        notaMaisAlta = nota > notaMaisAlta ? nota : notaMaisAlta;
        notaMaisBaixa = nota < notaMaisBaixa ? nota : notaMaisBaixa;
    }

    somaDasNotas += nota;
    quantidadeAlunos++;
    
} while (true);

double media = somaDasNotas / quantidadeAlunos;

Console.WriteLine($"A nota mais alta é {notaMaisAlta}");
Console.WriteLine($"A nota mais baixa é {notaMaisBaixa}");
Console.WriteLine($"A média da turma é {media.ToString("N2")}");
Console.WriteLine($"A quantidade de alunos é {quantidadeAlunos}");
