// 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
// certa região, a qual coletou os seguintes dados referentes a cada habitante para 
// serem analisados:
// - sexo (masculino e feminino)
// - cor dos olhos (azuis, verdes ou castanhos)
// - cor dos cabelos ( louros, castanhos, pretos)
// - idade 

// Faça um algoritmo que determine e escreva: 

// - a maior idade dos habitantes
// - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
// e que tenham olhos verdes e cabelos louros.
// O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.

int maiorIdade = 0;
int quantidadeDeMulheresComOlhosVerdesECabelosLouros = 0;

do
{
    Console.WriteLine($"Digite a idade: ");
    int idade = int.Parse(Console.ReadLine()!);

    if (idade < 0) break;

    Console.WriteLine($"Digite o sexo: ");
    string sexo = Console.ReadLine()!;

    Console.WriteLine($"Digite a cor dos olhos: ");
    string corDosOlhos = Console.ReadLine()!;

    Console.WriteLine($"Digite a cor dos cabelos: ");
    string corDosCabelos = Console.ReadLine()!;

    maiorIdade = Math.Max(idade, maiorIdade);

    if (sexo == "feminino" && idade >= 18 && idade <= 35 && corDosOlhos == "verdes" && corDosCabelos == "louros")
    {
        quantidadeDeMulheresComOlhosVerdesECabelosLouros++;
    }

} while (true);

Console.WriteLine($"A maior idade dos habitantes é: {maiorIdade}");
Console.WriteLine($"A quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive e que tenham olhos verdes e cabelos louros é: {quantidadeDeMulheresComOlhosVerdesECabelosLouros}");