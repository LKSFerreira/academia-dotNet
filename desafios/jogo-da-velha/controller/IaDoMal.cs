public class IaDoMal
{
    private int Minimax(string tabuleiro, int profundidade, bool ehMaximizador, HashSet<string> coordenadasOcupadas)
    {
        // Verifica se o jogo terminou (vitória ou empate)
        int pontuacao = VerificaVitoria(tabuleiro);
        if (pontuacao == 10 || pontuacao == -10 || profundidade == 0 || coordenadasOcupadas.Count == 9)
        {
            return pontuacao;
        }

        if (ehMaximizador)
        {
            int melhorPontuacao = int.MinValue;
            for (int i = 1; i <= 9; i++)
            {
                string jogada = i.ToString();
                if (!coordenadasOcupadas.Contains(jogada))
                {
                    // Faz a jogada
                    tabuleiro = tabuleiro.Substring(0, i - 1) + "X" + tabuleiro.Substring(i);
                    coordenadasOcupadas.Add(jogada);

                    // Chama o algoritmo minimax recursivamente
                    melhorPontuacao = Math.Max(melhorPontuacao, Minimax(tabuleiro, profundidade - 1, !ehMaximizador, coordenadasOcupadas));

                    // Desfaz a jogada
                    tabuleiro = tabuleiro.Substring(0, i - 1) + " " + tabuleiro.Substring(i);
                    coordenadasOcupadas.Remove(jogada);
                }
            }
            return melhorPontuacao;
        }
        else
        {
            int melhorPontuacao = int.MaxValue;
            for (int i = 1; i <= 9; i++)
            {
                string jogada = i.ToString();
                if (!coordenadasOcupadas.Contains(jogada))
                {
                    // Faz a jogada
                    tabuleiro = tabuleiro.Substring(0, i - 1) + "O" + tabuleiro.Substring(i);
                    coordenadasOcupadas.Add(jogada);

                    // Chama o algoritmo minimax recursivamente
                    melhorPontuacao = Math.Min(melhorPontuacao, Minimax(tabuleiro, profundidade - 1, !ehMaximizador, coordenadasOcupadas));

                    // Desfaz a jogada
                    tabuleiro = tabuleiro.Substring(0, i - 1) + " " + tabuleiro.Substring(i);
                    coordenadasOcupadas.Remove(jogada);
                }
            }
            return melhorPontuacao;
        }
    }

    private int VerificaVitoria(string tabuleiro)
    {
        // Verifica linhas
        for (int i = 0; i <= 6; i += 3)
        {
            if (tabuleiro[i] == tabuleiro[i + 1] && tabuleiro[i + 1] == tabuleiro[i + 2])
            {
                if (tabuleiro[i] == 'X')
                {
                    return +10;
                }
                else if (tabuleiro[i] == 'O')
                {
                    return -10;
                }
            }
        }

        // Verifica colunas
        for (int i = 0; i < 3; i++)
        {
            if (tabuleiro[i] == tabuleiro[i + 3] && tabuleiro[i + 3] == tabuleiro[i + 6])
            {
                if (tabuleiro[i] == 'X')
                {
                    return +10;
                }
                else if (tabuleiro[i] == 'O')
                {
                    return -10;
                }
            }
        }

        // Verifica diagonais
        if (tabuleiro[0] == tabuleiro[4] && tabuleiro[4] == tabuleiro[8])
        {
            if (tabuleiro[0] == 'X')
            {
                return +10;
            }
            else if (tabuleiro[0] == 'O')
            {
                return -10;
            }
        }

        if (tabuleiro[2] == tabuleiro[4] && tabuleiro[4] == tabuleiro[6])
        {
            if (tabuleiro[2] == 'X')
            {
                return +10;
            }
            else if (tabuleiro[2] == 'O')
            {
                return -10;
            }
        }

        // Se não houver vitória, retorna 0
        return 0;
    }

    public string MelhorJogada(string tabuleiro, HashSet<string> coordenadasOcupadas)
    {
        // Verifica se o oponente jogou em uma das quinas
        int[,] quinasOpostas = new int[4, 2] { { 1, 9 }, { 3, 7 }, { 7, 3 }, { 9, 1 } };
        for (int i = 0; i < quinasOpostas.GetLength(0); i++)
        {
            string quinaOponente = quinasOpostas[i, 0].ToString();
            string quinaOpsta = quinasOpostas[i, 1].ToString();
            if (tabuleiro[quinasOpostas[i, 0] - 1] == 'O' && !coordenadasOcupadas.Contains(quinaOpsta))
            {
                // Se sim, escolhe a quina oposta como a melhor jogada
                return quinaOpsta;
            }
        }

        // Verifica se alguma das quinas está disponível
        int[] quinas = new int[] { 1, 3, 7, 9 };
        foreach (int quina in quinas)
        {
            string jogada = quina.ToString();
            if (!coordenadasOcupadas.Contains(jogada))
            {
                // Se sim, escolhe a quina como a melhor jogada
                return jogada;
            }
        }

        // Se nenhuma das quinas estiver disponível, usa o algoritmo minimax para encontrar a melhor jogada
        int melhorPontuacao = int.MinValue;
        string melhorJogada = "";

        for (int i = 1; i <= 9; i++)
        {
            string jogada = i.ToString();
            if (!coordenadasOcupadas.Contains(jogada))
            {
                // Faz a jogada
                tabuleiro = tabuleiro.Substring(0, i - 1) + "X" + tabuleiro.Substring(i);
                coordenadasOcupadas.Add(jogada);

                // Chama o algoritmo minimax
                int pontuacao = Minimax(tabuleiro, 9 - coordenadasOcupadas.Count, false, coordenadasOcupadas);

                // Desfaz a jogada
                tabuleiro = tabuleiro.Substring(0, i - 1) + " " + tabuleiro.Substring(i);
                coordenadasOcupadas.Remove(jogada);

                // Atualiza a melhor pontuação e a melhor jogada
                if (pontuacao > melhorPontuacao)
                {
                    melhorPontuacao = pontuacao;
                    melhorJogada = jogada;
                }
            }
        }

        return melhorJogada;

    }

}
