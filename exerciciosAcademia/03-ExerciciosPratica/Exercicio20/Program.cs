// 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto. O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. 
// plus: você pode gerar o número de forma randomica (função random c#).

Console.WriteLine($"Digite um número de 1 a 10");
int numeroSecreto = new Random().Next(1, 11);
int numeroTentativas = 3;
int numeroTentativaAtual = 1;

while (numeroTentativaAtual <= numeroTentativas)
{
    Console.WriteLine($"Tentativa {numeroTentativaAtual} de {numeroTentativas}");
    int numeroInformado = int.Parse(Console.ReadLine()!);

    if (numeroInformado == numeroSecreto)
    {
        Console.WriteLine($"Você acertou!");
        break;
    }
    else if (numeroInformado > numeroSecreto)
    {
        Console.WriteLine($"O número informado é maior que o número secreto");
    }
    else
    {
        Console.WriteLine($"O número informado é menor que o número secreto");
    }

    numeroTentativaAtual++;
}

if (numeroTentativaAtual > numeroTentativas)
{
    Console.WriteLine($"Você perdeu! O número secreto era {numeroSecreto}");
}