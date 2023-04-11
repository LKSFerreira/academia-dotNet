// 6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
// aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final 
// (média das notas das avaliações).

Console.WriteLine($"Digite a quantidade de alunos da turma: ");
int qtdAlunos = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a quantidade de avaliações: ");
int qtdAvaliacoes = int.Parse(Console.ReadLine()!);

for (int i = 0; i < qtdAlunos; i++)
{
    double soma = 0;
    for (int j = 0; j < qtdAvaliacoes; j++)
    {
        Console.WriteLine($"Digite a nota da avaliação {j + 1} do aluno {i + 1}: ");
        double nota = double.Parse(Console.ReadLine()!);
        soma += nota;
    }

    double media = soma / qtdAvaliacoes;
    Console.WriteLine($"A média do aluno {i + 1} é {media}");
}

