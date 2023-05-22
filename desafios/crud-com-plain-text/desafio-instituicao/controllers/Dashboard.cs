using desafio_instituicao.view;

namespace desafio_instituicao.controllers;

public class Dashboard
{
    public static void Inicio()
    {
        ArtASCII.Logo();
    }
    public static void Menu()
    {
        Console.WriteLine($"{ArtASCII.AdicionarRegistro}");
        Console.WriteLine($"{ArtASCII.ListarRegistro}");
        Console.WriteLine($"{ArtASCII.BuscarRegistro}");
        Console.WriteLine($"{ArtASCII.EditarRegistro}");
        Console.WriteLine($"{ArtASCII.ExcluirRegistro}");
        Console.WriteLine($"{ArtASCII.Sair}");
    }
}
