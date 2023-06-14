using System;
using System.Collections.Generic;

namespace EntityFrameworkDBFirst.Models;

public partial class Email
{
    public int Id { get; set; }

    public string Email1 { get; set; }

    public int? FkPessoa { get; set; }

    public virtual Pessoa FkPessoaNavigation { get; set; }
}
