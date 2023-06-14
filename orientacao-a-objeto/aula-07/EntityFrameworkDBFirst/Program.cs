using EntityFrameworkDBFirst;
using EntityFrameworkDBFirst.Models;

Console.WriteLine($"\nDigite a opção desejada:\n");
Console.WriteLine($"1 - Adicionar o registro de uma pessoa");
Console.WriteLine($"2 - Alterar o nome de uma pessoa");
Console.WriteLine($"3 - Adicionar um email a uma pessoa");
Console.WriteLine($"4 - Excluir uma pessoa");
Console.WriteLine($"5 - Consultar tudo");
Console.WriteLine($"6 - Consultar pelo ID");

int opcao = int.Parse(Console.ReadLine()!);
Console.WriteLine();

DbfirstContext contexto = new DbfirstContext();

switch (opcao)
{
    case 1:
        Pessoa.adicionar();
        break;
    case 2:
        Pessoa.alterar();
        break;
    case 3:
        Pessoa.adicionarEmail();
        break;
    case 4:
        Pessoa.excluir();
        break;
    case 5:
        Pessoa.consultar();
        break;
    case 6:
        Pessoa.consultarPorId();
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}