public class JogoDaVelhaController
{
    public void OpcoesMenu(int opcaoMenu)
    {
        JogoDaVelha jogoDaVelha = new JogoDaVelha();
        Dashbord dashbord = new Dashbord();

        switch (opcaoMenu)
        {
            case 1:
                jogoDaVelha.SelecionarJogadores();
                break;
            case 2:
                dashbord.ExibirRank();
                break;
            case 3:
                dashbord.ExibeJogador();
                break;
            case 0:
                Environment.Exit(0);
                break;
            default:
                Console.Clear();
                Console.WriteLine($"    Por favor seleciona uma opção válida \n");
                break;
        }
    }

    private IDictionary<string, int> coordTabuleiro = new Dictionary<string, int>
    {
        {"A1",146},
        {"B1",152},
        {"C1",158},
        {"A2",92},
        {"B2",98},
        {"C2",104},
        {"A3",38},
        {"B3",44},
        {"C3",50}
    };

    private HashSet<string> coordenadasOcupadas = new HashSet<string>();

    private IDictionary<string, int> coordOcupadas = new Dictionary<string, int>
    {
        {"A1",1},
        {"B1",2},
        {"C1",3},
        {"A2",4},
        {"B2",5},
        {"C2",6},
        {"A3",7},
        {"B3",8},
        {"C3",9}
    };
    private HashSet<string> posicoesRelativas = new HashSet<string>
        { "A1", "A2", "A3", "B1", "B2", "B3", "C1", "C2", "C3", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

    public Tuple<int, string, string> RealizarJogada(string tabuleiro, string coordenada, string X_ou_O)
    {
        while (!posicoesRelativas.Contains(coordenada))
        {
            Console.WriteLine($"Por gentileza, digite um coordenada válida");
            coordenada = Console.ReadLine()!.ToUpper();
        }

        while (coordenadasOcupadas.Contains(coordenada))
        {
            Console.WriteLine($"Coordenada já ocupada, por gentileza digite outra posição");
            coordenada = Console.ReadLine()!.ToUpper();
        }

        int coord = 0;
        coord = ConverterCoordenadaEmCoord(ref coordenada);

        coordenadasOcupadas.Add(coordenada);
        coordenadasOcupadas.Add(coordOcupadas[coordenada].ToString());

        tabuleiro = tabuleiro.Remove(coordTabuleiro[coordenada], 1).Insert(coordTabuleiro[coordenada], X_ou_O);
        return Tuple.Create(coordTabuleiro[coordenada], tabuleiro, coordenada);
    }

    private int ConverterCoordenadaEmCoord(ref string coordenada)
    {
        int coord;
        if (int.TryParse(coordenada, out coord))
        {
            switch (coord)
            {
                case 1:
                    coordenada = "A1";
                    break;
                case 2:
                    coordenada = "B1";
                    break;
                case 3:
                    coordenada = "C1";
                    break;
                case 4:
                    coordenada = "A2";
                    break;
                case 5:
                    coordenada = "B2";
                    break;
                case 6:
                    coordenada = "C2";
                    break;
                case 7:
                    coordenada = "A3";
                    break;
                case 8:
                    coordenada = "B3";
                    break;
                case 9:
                    coordenada = "C3";
                    break;
            }
        };
        return coord;
    }

    public static bool CondicionalVitoria(string tabuleiro, string jogador_X_ou_O)
    {
        char valor = jogador_X_ou_O[0];

        foreach (var letra in tabuleiro)
        {
            if (letra == valor)
            {
                if ((tabuleiro.ElementAt(146) == valor && tabuleiro.ElementAt(92) == valor && tabuleiro.ElementAt(38) == valor) ||
                    (tabuleiro.ElementAt(152) == valor && tabuleiro.ElementAt(98) == valor && tabuleiro.ElementAt(44) == valor) ||
                    (tabuleiro.ElementAt(158) == valor && tabuleiro.ElementAt(104) == valor && tabuleiro.ElementAt(50) == valor) ||
                    (tabuleiro.ElementAt(146) == valor && tabuleiro.ElementAt(152) == valor && tabuleiro.ElementAt(158) == valor) ||
                    (tabuleiro.ElementAt(92) == valor && tabuleiro.ElementAt(98) == valor && tabuleiro.ElementAt(104) == valor) ||
                    (tabuleiro.ElementAt(38) == valor && tabuleiro.ElementAt(44) == valor && tabuleiro.ElementAt(50) == valor) ||
                    (tabuleiro.ElementAt(146) == valor && tabuleiro.ElementAt(98) == valor && tabuleiro.ElementAt(50) == valor) ||
                    (tabuleiro.ElementAt(38) == valor && tabuleiro.ElementAt(98) == valor && tabuleiro.ElementAt(158) == valor))
                {
                    return true;
                }
            }
        }
        return false;
    }
}