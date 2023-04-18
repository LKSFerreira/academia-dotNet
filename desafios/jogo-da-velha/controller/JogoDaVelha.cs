public class JogoDaVelha
{
    Dashbord dashbord = new Dashbord();

    public void SelecionarJogadores()
    {
        Jogador jogador01 = dashbord.PvP();
        Jogador jogador02 = dashbord.PvP();
        Console.WriteLine($"    {jogador01.Nome} pronto(a)! Para o adversário(a)\n");
        Console.WriteLine($"    {jogador02.Nome} preparado(a) para começar!\n ");
        Thread.Sleep(3000);

        Console.Clear();

        ArtASCII.ConstruirNomeArtASCII($"{jogador01.Nome} VS {jogador02.Nome}");

        IniciarPartida(jogador01, jogador02);
    }

    private void IniciarPartida(Jogador player01, Jogador player02)
    {
        JogoDaVelhaController jogoDaVelhaController = new JogoDaVelhaController();

        Console.WriteLine($"    Sorteando primeira jogada... ");
        Thread.Sleep(1500);
        Console.Clear();

        var jogadorDaVez = dashbord.SortearJogador(player01, player02);
        Console.Clear();
        Console.WriteLine($"    Digite as coordenada pela LETRA + NÚMERO ou você pode utilizar SOMENTE os números do seu teclado como refência para a posição.");
        var tabuleiro = ArtASCII._TabuleiroDaVelha;


        Console.WriteLine($"    {tabuleiro}\n");

        int numeroDeJogadas = 0;
        Random random = new Random();

        // HashSet<int> numerosSorteados = new();
        HashSet<int> jogadasPlayer01 = new();
        HashSet<int> jogadasPlayer02 = new();

        // while (numerosSorteados.Count < 9)
        // {
        //     int numeroAleatorio = random.Next(1, 10);
        //     numerosSorteados.Add(numeroAleatorio);
        // }

        int quantidadeJogadas = 0, jogada = 1;
        string jogadorX = "X", jogadorO = "O";

        do
        {

            Console.WriteLine($"    {jogada}\u00aa jogada de: {jogadorDaVez[0].Nome}");
            string jogadaDoPlayer01 = Console.ReadLine()!.ToUpper();

            var realizadaJogada = jogoDaVelhaController.RealizarJogada(tabuleiro, jogadaDoPlayer01, jogadorX);
            tabuleiro = realizadaJogada.Item2;
            jogadasPlayer01.Add(realizadaJogada.Item1);

            quantidadeJogadas++;
            jogada++;
            numeroDeJogadas++;

            Console.Clear();

            Console.WriteLine($"    {tabuleiro}\n");

            if (JogoDaVelhaController.CondicionalVitoria(tabuleiro, jogadorX))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{jogadorDaVez[0].Nome} Venceu");
                Console.ResetColor();
                return;
            }

            Thread.Sleep(100);

            if (quantidadeJogadas == 9) break;


            Console.WriteLine($"    {jogada}\u00aa jogada de: {jogadorDaVez[1].Nome}");
            string jogadaPlayer02 = Console.ReadLine()!.ToUpper();

            realizadaJogada = jogoDaVelhaController.RealizarJogada(tabuleiro, jogadaPlayer02, jogadorO);
            tabuleiro = realizadaJogada.Item2;
            jogadasPlayer02.Add(realizadaJogada.Item1);

            quantidadeJogadas++;
            jogada++;
            numeroDeJogadas++;

            Console.Clear();

            Console.WriteLine($"    {tabuleiro}\n");

            if (JogoDaVelhaController.CondicionalVitoria(tabuleiro, jogadorO))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{jogadorDaVez[1].Nome} Venceu");
                Console.ResetColor();
                return;
            }
            Thread.Sleep(100);
        } while (numeroDeJogadas < 9);
    }



}