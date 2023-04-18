// 8. Faça um programa em VS que solicite um numero inteiro. S
// e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
// Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.

bool continuaRepeticao;
int numeroInteiro;

do
{
    do
    {
        Console.WriteLine($"Digite um número inteiro: ");
        string valorDeveSerUmInteiro = (Console.ReadLine()!);

        if (int.TryParse(valorDeveSerUmInteiro, out numeroInteiro))
        {
            break;
        }

    } while (true);


    if (numeroInteiro % 2 == 0)
    {
        Console.WriteLine($"O número é par");
    }
    else
    {
        Console.WriteLine($"O número é ímpar");
    }

    Console.WriteLine($"Deseja repetir o programa (s/n)? ");
    continuaRepeticao = Console.ReadLine()! == "s" ? true : false;

} while (continuaRepeticao);