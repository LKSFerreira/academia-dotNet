// 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
// Se o usuário digitar 0 o programa em VS deve parar. 
// Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo. 

do
{
    Console.WriteLine($"Digite um número inteiro positivo: ");
    int numeroInteiroPositivo = int.Parse(Console.ReadLine()!);

    if (numeroInteiroPositivo == 0)
    {
        break;
    }

    if (numeroInteiroPositivo % 2 == 0)
    {
        Console.WriteLine($"O número é par");
    }
    else
    {
        Console.WriteLine($"O número é ímpar");
    }

    bool numeroPrimo = true;

    for (int i = 2; i < numeroInteiroPositivo; i++)
    {
        if (numeroInteiroPositivo % i == 0)
        {
            numeroPrimo = false;
            break;
        }
    }

    if (numeroPrimo)
    {
        Console.WriteLine($"O número é primo");
    }
    else
    {
        Console.WriteLine($"O número não é primo");
    }

    Console.WriteLine($"====================");

} while (true);
