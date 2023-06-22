namespace ConsumindoRestAPI.models;

public class Acesso
{

    public string? Usuario { get; }
    public string? Senha { get; }

    public Acesso(string? usuario, string? senha)
    {
        Usuario = usuario;
        Senha = senha;
    }


}
