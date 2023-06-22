namespace ConsumindoRestAPI.models;

public class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    public Pessoa(string nome)
    {
        this.Nome = nome;
    }

    public override string? ToString()
    {
        return $"Id: {Id,-5} | Nome: {Nome,-15}";
    }
}
