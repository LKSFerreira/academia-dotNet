// 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
// ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
// Ao final, mostre a idade digitada.

int idade = 0;
do
{
    Console.WriteLine($"Digite a idade: ");
} while (int.TryParse(Console.ReadLine()!, out idade) && idade <= 0) ;

Console.WriteLine($"Idade: {idade}");