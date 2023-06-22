using ConsumindoRestAPI.services;

Console.WriteLine($"\nConsumindo API Rest");
int opcao;
string token = "";

do
{
    Console.WriteLine($"\nInforme uma opção:");
    Console.WriteLine($"1 - Listar pessoas");
    Console.WriteLine($"2 - Cadastrar pessoa");
    Console.WriteLine($"3 - Atualizar pessoa");
    Console.WriteLine($"4 - Deletar pessoa");
    Console.WriteLine($"5 - Buscar pessoa por ID");
    Console.WriteLine($"-------------------------");
    Console.WriteLine($"Consumindo JWT");
    Console.WriteLine($"-------------------------");
    Console.WriteLine($"6 - Solicitar token de acesso");
    Console.WriteLine($"7 - Consumir API com token de acesso");
    Console.WriteLine($"-------------------------");
    Console.WriteLine($"0 - Sair");

    Console.WriteLine($"");
    opcao = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"");

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Saindo...");
            break;
        case 1:
            Console.WriteLine($"Listando pessoas...");
            PessoaService.Listar();
            Console.WriteLine($"");
            Thread.Sleep(1500);
            break;

        case 2:
            Console.WriteLine($"Cadastrando pessoa...");
            PessoaService.Cadastrar();
            Console.WriteLine($"");
            Thread.Sleep(1500);
            break;
        case 3:
            Console.WriteLine($"Atualizando pessoa...");
            PessoaService.Atualizar();
            Console.WriteLine($"");
            Thread.Sleep(1500);
            break;
        case 4:
            Console.WriteLine($"Deletando pessoa...");
            PessoaService.Remover();
            Console.WriteLine($"");
            Thread.Sleep(1500);
            break;
        case 5:
            Console.WriteLine($"Buscando pessoa por ID...");
            PessoaService.BuscarPorId();
            Console.WriteLine($"");
            Thread.Sleep(1500);
            break;
        case 6:
            Console.WriteLine($"Solicitando token de acesso...");
            token = PessoaService.SolicitarToken();
            break;
        case 7:
            Console.WriteLine($"Consumindo API com token de acesso...");
            PessoaService.ConsumirAPIComToken(token);
            Console.WriteLine($"");
            break;
        default:
            Console.WriteLine($"Opção inválida");
            break;
    }

} while (opcao != 0);