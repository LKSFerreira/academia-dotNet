// 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
// Número de pessoas do sexo masculino.
// Número de pessoas do sexo feminino.
// Número de pessoas com idade inferior a 30 anos.
// Número de pessoas com idade superior a 60 anos.
// Média de idade das mulheres.

int qtdPessoasSexoMasculino = 0;
int qtdPessoasSexoFeminino = 0;
int qtdPessoasComIdadeInferior30Anos = 0;
int qtdPessoasComIdadeSuperior60Anos = 0;
double somaIdadeSexoFeminino = 0;
double mediaIdadeSexoFeminino = 0;

for (int i = 0; i < 50; i++)
{
    Console.WriteLine($"Digite o nome da pessoa: ");
    string nome = Console.ReadLine()!;
    Console.WriteLine($"Digite o sexo da pessoa (m/f): ");
    string sexo = Console.ReadLine()!;
    Console.WriteLine($"Digite a idade da pessoa: ");
    int idade = int.Parse(Console.ReadLine()!);

    qtdPessoasSexoMasculino += sexo == "m" ? 1 : 0;
    qtdPessoasSexoFeminino += sexo == "f" ? 1 : 0;
    qtdPessoasComIdadeInferior30Anos += idade < 30 ? 1 : 0;
    qtdPessoasComIdadeSuperior60Anos += idade > 60 ? 1 : 0;
    somaIdadeSexoFeminino += sexo == "f" ? idade : 0;
}

mediaIdadeSexoFeminino = somaIdadeSexoFeminino / qtdPessoasSexoFeminino;

Console.WriteLine($"Número de pessoas do sexo masculino: {qtdPessoasSexoMasculino}");
Console.WriteLine($"Número de pessoas do sexo feminino: {qtdPessoasSexoFeminino}");
Console.WriteLine($"Número de pessoas com idade inferior a 30 anos: {qtdPessoasComIdadeInferior30Anos}");
Console.WriteLine($"Número de pessoas com idade superior a 60 anos: {qtdPessoasComIdadeSuperior60Anos}");
Console.WriteLine($"Média de idade das mulheres: {mediaIdadeSexoFeminino}");
