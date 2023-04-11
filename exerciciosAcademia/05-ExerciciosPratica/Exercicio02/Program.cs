// 2. Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
// informar um outro número. Caso positivo, o programa em VS deve ser repetido.

// Exemplo:
// Digite um número inteiro positivo: 8
// Numero digitado: 8
// Números inteiros pares entre 1 e 8: 2, 4, 6.

// Deseja informar outro número (s/n)? S

// Digite um número inteiro positivo: 12
// Numero digitado: 20
// Números inteiros pares entre 1 e 8: 2, 4, 6, 8, 10.

// Deseja informar outro número (s/n)? N 

string resposta;

do
{
    Console.WriteLine($"Digite um número inteiro positivo: ");
    int numeroInteiroPositivo = int.Parse(Console.ReadLine()!);

    while (numeroInteiroPositivo <= 0)
    {
        Console.WriteLine($"O número deve ser inteiro positivo. Digite novamente: ");
        numeroInteiroPositivo = int.Parse(Console.ReadLine()!);
    }

    for (int i = 1; i <= numeroInteiroPositivo; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }

    Console.WriteLine($"Deseja informar outro número (s/n)? ");
    resposta = Console.ReadLine()!;

} while (resposta == "s");


