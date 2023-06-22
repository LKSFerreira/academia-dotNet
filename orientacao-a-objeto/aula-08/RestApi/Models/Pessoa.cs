using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace RestApi.Models;

public class Pessoa
{
    public int Id { get; set; }
    public string? Nome { get; set; }

    [JsonIgnore]
    public virtual ICollection<Email>? Emails { get; set; }
}

