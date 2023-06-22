namespace Singleton.Models;

public class Pessoa
{
    private static readonly Pessoa pessoa = new();
    private Pessoa() { }

    public string Nome { get; set; } = null!;

    public static Pessoa GetInstance() { return pessoa;}

}
