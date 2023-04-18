// 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
// o zoológico num determinado dia, imprimindo:
// Quantas pessoas tem entre 1 e 3 filhos.
// Quantas pessoas tem entre 4 e 7 filhos.
// Quantas pessoas tem mais de 8 filhos.
// Quantas pessoas não tem filhos.

Console.WriteLine($"Digite a quantidade de filhos de cada uma das 30 pessoas que visitaram o zoológico num determinado dia: ");
int qtdPessoas = 5;
int qtdPessoasSemFilhos = 0;
int qtdPessoasCom1a3Filhos = 0;
int qtdPessoasCom4a7Filhos = 0;
int qtdPessoasComMaisDe8Filhos = 0;

for (int i = 0; i < qtdPessoas; i++)
{
    Console.WriteLine($"Digite a quantidade de filhos da pessoa {i + 1}: ");
    int qtdFilhos = int.Parse(Console.ReadLine()!);

    qtdPessoasSemFilhos += qtdFilhos == 0 ? 1 : 0;
    qtdPessoasCom1a3Filhos += qtdFilhos >= 1 && qtdFilhos <= 3 ? 1 : 0;
    qtdPessoasCom4a7Filhos += qtdFilhos >= 4 && qtdFilhos <= 7 ? 1 : 0;
    qtdPessoasComMaisDe8Filhos += qtdFilhos >= 8 ? 1 : 0;
    
}

Console.WriteLine($"Quantas pessoas tem entre 1 e 3 filhos: {qtdPessoasCom1a3Filhos}");
Console.WriteLine($"Quantas pessoas tem entre 4 e 7 filhos: {qtdPessoasCom4a7Filhos}");
Console.WriteLine($"Quantas pessoas tem mais de 8 filhos: {qtdPessoasComMaisDe8Filhos}");
Console.WriteLine($"Quantas pessoas não tem filhos: {qtdPessoasSemFilhos}");
