namespace RestApi.Models;

public class Email
{
    public int id { get; set; }
    public string? email { get; set; }
    public virtual Pessoa? pessoa { get; set; }
}
