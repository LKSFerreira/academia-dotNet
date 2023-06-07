namespace EntityFramework.DataModels;

public class Pessoa
{
    public int id { get; set; }
    public string nome { get; set; }
    public virtual ICollection<Email> emails { get; set; }
    
}
