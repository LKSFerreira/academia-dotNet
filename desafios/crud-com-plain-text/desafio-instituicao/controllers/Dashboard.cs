using desafio_instituicao.view;

namespace desafio_instituicao.controllers;

public class Dashboard
{
    private static Registro registro = new Registro();
    public static void Inicio()
    {
        ArtASCII.Logo();
    }
    public static void Menu()
    {
        // Console.WriteLine($"{ArtASCII.AdicionarRegistro}");
        Console.WriteLine($"{ArtASCII.ListarRegistro}");
        // Console.WriteLine($"{ArtASCII.BuscarRegistro}");
        // Console.WriteLine($"{ArtASCII.EditarRegistro}");
        // Console.WriteLine($"{ArtASCII.ExcluirRegistro}");
        Console.WriteLine($"{ArtASCII.Sair}");

        Action opcaoSelecionada = SelecionarMenu() switch
        {
            // 1 => AdicionarRegistro,
            2 => ListarRegistro,
            // 3 => BuscarRegistro,
            // 4 => EditarRegistro,
            // 5 => ExcluirRegistro,
            6 => Sair,
            _ => OpcaoInvalida
        };

        opcaoSelecionada();
    }

    private static int SelecionarMenu()
    {
        string entradaUsuario = Console.ReadLine();
        int opcaoMenu = 0;

        if (entradaUsuario == null) return 6;

        if (!int.TryParse(entradaUsuario, out opcaoMenu))
        {
            Console.WriteLine($"    Por gentileza, apenas números.");
        }
        return opcaoMenu;
    }
    private static void OpcaoInvalida()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"    Por gentileza, digite um valor correspondente ao menu.");
        Console.ResetColor();
        Thread.Sleep(2000);
    }

    private static void AdicionarRegistro()
    {
        Console.WriteLine($"{ArtASCII.AdicionarRegistro}");
    }

    private static void ListarRegistro()
    {
        Console.Clear();
        ArtTitle.Registro();
        registro.Listar();
        Menu();
    }

    private static void BuscarRegistro()
    {
        Console.WriteLine($"{ArtASCII.BuscarRegistro}");
    }

    private static void EditarRegistro()
    {
        Console.WriteLine($"{ArtASCII.EditarRegistro}");
    }

    private static void ExcluirRegistro()
    {
        Console.WriteLine($"{ArtASCII.ExcluirRegistro}");
    }

    private static void Sair()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"    Obrigado por utilizar o sistema!");
        Console.ResetColor();
        Thread.Sleep(3000);
        Environment.Exit(0);
    }
}




