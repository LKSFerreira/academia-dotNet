namespace desafio_instituicao.model.Pessoas;

public abstract class Pessoa
{
    protected string Nome { get; set; }
    protected string Telefone { get; set; }
    protected string Cidade { get; set; }
    protected string Rg { get; set; }
    protected string Cpf { get; set; }

    protected Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
    {
        Nome = nome;
        Telefone = telefone;
        Cidade = cidade;
        Rg = rg;
        Cpf = cpf;
    }
}
