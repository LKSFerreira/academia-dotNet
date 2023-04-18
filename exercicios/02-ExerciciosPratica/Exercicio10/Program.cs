// 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
// O programa deve mostrar os dados do atleta mais novo e mais alto.

Console.WriteLine($"Digite o nome do primeiro atleta: ");
string nomeAtleta1 = Console.ReadLine()!;
Console.WriteLine($"Digite a idade do atleta: ");
int idadeAtleta1 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite a altura do atleta: ");
double alturaAtleta1 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o nome do segundo atleta: ");
string nomeAtleta2 = Console.ReadLine()!;
Console.WriteLine($"Digite a idade do atleta: ");
int idadeAtleta2 = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Digite a altura do atleta: ");
double alturaAtleta2 = double.Parse(Console.ReadLine()!);

Console.WriteLine($"");

if (idadeAtleta1 < idadeAtleta2)
{
    Console.WriteLine($"O nome do atleta mais novo é {nomeAtleta1} com {idadeAtleta1} anos e a altura é {alturaAtleta1} metros.");
}
else if (idadeAtleta1 > idadeAtleta2)
{
    Console.WriteLine($"O atleta mais novo é {nomeAtleta2} com {idadeAtleta2} anos e a altura é {alturaAtleta2} metros.");
}
else
{
    if (alturaAtleta1 > alturaAtleta2)
    {
        Console.WriteLine($"O atleta mais alto é {nomeAtleta1} com {idadeAtleta1} anos e a altura é {alturaAtleta1} metros.");
    }
    else if (alturaAtleta1 < alturaAtleta2)
    {
        Console.WriteLine($"O atleta mais alto é {nomeAtleta2} com {idadeAtleta2} anos e a altura é {alturaAtleta2} metros.");
    }
    else
    {
        Console.WriteLine($"Os atletas {nomeAtleta1} e {nomeAtleta2} tem a mesma idade e altura.");
    }
}