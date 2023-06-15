namespace ConsumindoRestAPI.models;

public class Pessoa
{
    public int id { get; set; }
    public string? nome { get; set; }

    public Pessoa(string nome)
    {
        this.nome = nome;
    }

    public override string? ToString()
    {
        return $"Id: {id, -5} | Nome: {nome, -15}";
    }
}
