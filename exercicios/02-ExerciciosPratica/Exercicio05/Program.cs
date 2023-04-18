// 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” 
// se a média das duas notas for maior ou igual a 7,0. 

// Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
// é a média entre a nota do exame e a média das 2 notas. 
// Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
// escrever “Reprovado”.

Console.WriteLine($"Digite a primeira nota do aluno: ");
double nota1 = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite a segunda nota do aluno: ");
double nota2 = double.Parse(Console.ReadLine()!);

double media = (nota1 + nota2) / 2;

if (media >= 7.0)
{
    Console.WriteLine($"Aprovado");
}
else
{
    Console.WriteLine($"Digite a nota do exame: ");
    double notaExame = double.Parse(Console.ReadLine()!);
    double mediaFinal = (notaExame + media) / 2;

    if (mediaFinal >= 5.0)
    {
        Console.WriteLine($"Aprovado");
    }
    else
    {
        Console.WriteLine($"Reprovado");
    }
}