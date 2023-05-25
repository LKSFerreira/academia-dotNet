namespace desafio_instituicao_wf.models.pessoas;

public abstract class Pessoa
{
    public string Nome { get; private set; }
    public string Telefone { get; private set; }
    public string Cidade { get; private set; }
    public string Rg { get; }
    public string Cpf { get; }

    public Pessoa(string nome, string telefone, string cidade, string rg, string cpf)
    {
        Nome = nome;
        Telefone = telefone;
        Cidade = cidade;
        Rg = rg;
        Cpf = cpf;
    }

    public override string ToString()
    {
        return $"Titular: {Nome,-15} | Telefone: {Telefone,-12} | Cidade: {Cidade,-20} | CPF: {Cpf,-13} | RG: {Rg,-13}\n";
    }
}
