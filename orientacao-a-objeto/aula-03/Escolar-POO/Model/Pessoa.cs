namespace Escolar_POO.Model;

public abstract class Pessoa
{
    public string? Nome { get; protected set; }
    public int Idade { get; protected set; }

    public Pessoa(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
