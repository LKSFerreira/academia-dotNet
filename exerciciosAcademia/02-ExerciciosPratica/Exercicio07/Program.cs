// 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
// O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
// exemplo, A palavra encontra-se na frase   ou A palavra não se encontra na frase.

Console.WriteLine($"Digite uma frase: ");
string frase = Console.ReadLine()!.ToUpper()!;

Console.WriteLine($"Digite uma palavra para pesquisar na frase: ");
string palavra = Console.ReadLine()!.ToUpper()!;

if (frase.Contains(palavra))
{
    Console.WriteLine($"A palavra {palavra} se encontra na frase {frase}.");
}
else
{
    Console.WriteLine($"A palavra {palavra} não se encontra na frase {frase}.");
}