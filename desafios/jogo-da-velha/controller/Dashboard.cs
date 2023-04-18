using Newtonsoft.Json;

public class Dashbord
{
    private static string pathJogadores = "./data/jogadores.json";
    private static string jsonJogadores = File.ReadAllText(pathJogadores);
    JogoDaVelhaController jogoDaVelhaController = new JogoDaVelhaController();

    public void Iniciar()
    {
        Console.WriteLine($"{ArtASCII._JogoDaVelha}");

        Console.Write($"{ArtASCII._PvP}");
        Console.Write($"{ArtASCII._PvE}");
        Console.Write($"{ArtASCII._Sair}");
        Console.WriteLine($"");

        int opcaoMenu = SelecionarMenu();
        OpcoesMenu(opcaoMenu);
    }

    private void OpcoesMenu(int opcaoMenu)
    {
        switch (opcaoMenu)
        {
            case 1:
                Console.Clear();
                Menu(opcaoMenu);
                break;
            case 2:
                Console.Clear();
                Menu(opcaoMenu);
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"    Opcão inválida, digite uma opção dentro do menu");
                Console.ResetColor();
                Thread.Sleep(2000);
                break;
        }
    }

    public void Menu(int opcaoMenu)
    {
        Console.WriteLine($"    Digite uma opção:\n");
        Console.WriteLine($"    1 - Jogar");
        Console.WriteLine($"    2 - Rank");
        Console.WriteLine($"    3 - Estatísticas do jogador");
        Console.WriteLine($"    0 - Sair");

        if (opcaoMenu == 1) jogoDaVelhaController.OpcoesMenu(SelecionarMenu());
    }

    private int SelecionarMenu()
    {
        string entradaUsuario = Console.ReadLine()!;
        int opcaoMenu = 0;

        if (!int.TryParse(entradaUsuario, out opcaoMenu))
        {
            Console.WriteLine($"    Por gentileza, digite um número correspondente");
        }
        return opcaoMenu;
    }

    public Jogador PvP()
    {
        Console.WriteLine($"    Digite o nome do jogador");
        string nomeJogador = Console.ReadLine()!;


        if (BuscaJogador(nomeJogador) is null)
        {
            Jogador jogador = new Jogador(nomeJogador);
            AdicionaJogador(jogador);
            BuscaJogador(jogador.Nome);
            return jogador;
        }
        else
        {
            Jogador jogador = BuscaJogador(nomeJogador);
            return jogador;
        }
    }

    public void AdicionaJogador(Jogador jogador)
    {
        var jogadores = AtualizaJogadores();
        jogadores.Add(jogador);

        jsonJogadores = JsonConvert.SerializeObject(jogadores);

        File.WriteAllText(pathJogadores, jsonJogadores);
    }

    public Jogador BuscaJogador(string nomeJogador)
    {
        var jogadores = AtualizaJogadores();

        foreach (var jogador in jogadores.Where(player => player.Nome == nomeJogador))
        {
            ArtASCII.ConstruirNomeArtASCII(jogador.Nome);

            Console.WriteLine($"    Nome: {jogador.Nome}");
            Console.WriteLine($"    Vitórias: {jogador.Vitorias}");

            Console.Write($"\n");

            return jogador;
        }

        Jogador novoJogador = new Jogador(nomeJogador);
        return novoJogador;
    }


    private Jogador CriarJogador()
    {
        Console.WriteLine($"Digite o nome do Jogador: ");
        string nome = Console.ReadLine()!;
        Jogador jogador = new Jogador(nome);
        return jogador;
    }


    public static List<Jogador> AtualizaJogadores()
    {
        jsonJogadores = File.ReadAllText(pathJogadores);
        List<Jogador> jogadores = JsonConvert.DeserializeObject<List<Jogador>>(jsonJogadores)!;
        return jogadores;
    }

    public void ExibeJogador()
    {
        Console.WriteLine($"Digite o hash do jogador: ");
        string hashJogador = Console.ReadLine()!;

        Console.Clear();

        var jogadores = AtualizaJogadores();

        ListaJogadores(hashJogador, jogadores);
    }

    private void ListaJogadores(string hashJogador, List<Jogador> jogadores)
    {

        foreach (var jogador in jogadores.Where(player => player.HashJogador == hashJogador))
        {
            ArtASCII.ConstruirNomeArtASCII(jogador.Nome.ToUpper());

            Console.WriteLine($"    Quantidade de Partidas: {jogador.QuantidadePartidas}");
            Console.WriteLine($"    Vitórias: {jogador.Vitorias}");
            Console.WriteLine($"    Derrotas: {jogador.Derrotas}");
            Console.WriteLine($"    Empates: {jogador.Empates}");
        }
    }

    public Jogador[] SortearJogador(Jogador player1, Jogador player2)
    {
        Random random = new Random();
        int i = 0;
        for (i = 0; i < 8; i++)
        {
            if (i % 2 == 0)
            {
                ArtASCII.ConstruirNomeArtASCII(player1.Nome);
                Thread.Sleep(200);
                Console.Clear();
            }
            else
            {
                ArtASCII.ConstruirNomeArtASCII(player2.Nome);
                Thread.Sleep(200);
                Console.Clear();
            }
        }

        if (random.Next(0, 2) % 2 == 0)
        {
            ArtASCII.ConstruirNomeArtASCII(player1.Nome);
            Jogador[] jogadores = { player1, player2 };
            return jogadores;
        }
        else
        {
            ArtASCII.ConstruirNomeArtASCII(player2.Nome);
            Jogador[] jogadores = { player2, player1 };
            return jogadores;
        }
    }

    public void ExibirRank()
    {
        Console.Clear();
        Console.WriteLine($"{ArtASCII._Rank}");

        var jogadores = AtualizaJogadores();

        foreach (var jogador in jogadores.OrderByDescending(player => player.Vitorias))
        {
            Console.WriteLine($"    Nome: {jogador.Nome,-30} Vitórias: {jogador.Vitorias}");
        }
        Console.Write($"\n");
    }
}
