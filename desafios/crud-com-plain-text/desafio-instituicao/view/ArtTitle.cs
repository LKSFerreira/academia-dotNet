namespace desafio_instituicao.view;

public struct ArtTitle
{
    private static string _registro = @"
    ██████╗ ███████╗ ██████╗ ██╗███████╗████████╗██████╗  ██████╗ ███████╗
    ██╔══██╗██╔════╝██╔════╝ ██║██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██╔════╝
    ██████╔╝█████╗  ██║  ███╗██║███████╗   ██║   ██████╔╝██║   ██║███████╗
    ██╔══██╗██╔══╝  ██║   ██║██║╚════██║   ██║   ██╔══██╗██║   ██║╚════██║
    ██║  ██║███████╗╚██████╔╝██║███████║   ██║   ██║  ██║╚██████╔╝███████║
    ╚═╝  ╚═╝╚══════╝ ╚═════╝ ╚═╝╚══════╝   ╚═╝   ╚═╝  ╚═╝ ╚═════╝ ╚══════╝";

    public static void Registro()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(_registro);
        Console.ResetColor();
    }

}

