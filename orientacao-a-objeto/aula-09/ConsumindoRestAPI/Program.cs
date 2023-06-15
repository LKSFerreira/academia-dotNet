using ConsumindoRestAPI.services;


Console.WriteLine($"\nConsumindo API Rest");
int opcao;

do
{
    Console.WriteLine($"\nInforme uma opção:");
    Console.WriteLine($"1 - Listar pessoas");
    Console.WriteLine($"2 - Cadastrar pessoa");
    Console.WriteLine($"3 - Atualizar pessoa");
    Console.WriteLine($"4 - Deletar pessoa");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine($"");
    opcao = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"");

    PessoaService pessoaService = new PessoaService();
    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            break;
        case 1:
            Console.WriteLine($"Listando pessoas...");
            pessoaService.listar();
            Console.WriteLine($"");
            Thread.Sleep(1000);
            break;

        case 2:
            Console.WriteLine($"Cadastrando pessoa...");
            pessoaService.cadastrar();
            Console.WriteLine($"");
            Thread.Sleep(1000);
            break;
        case 3:
            Console.WriteLine($"Atualizando pessoa...");
            pessoaService.atualizar();
            Console.WriteLine($"");
            Thread.Sleep(1000);
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

} while (opcao != 0);