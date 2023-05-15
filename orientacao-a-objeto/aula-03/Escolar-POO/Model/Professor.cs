namespace Escolar_POO.Model;

public class Professor : Pessoa
{

    public string? Disciplina { get; private set; }
    public Professor(string? nome, int idade, string Disciplina) : base(nome, idade)
    {
        this.Disciplina = Disciplina;
    }


    public override string? ToString()
    {
        return $"Nome: {this.Nome}\nIdade: {this.Idade}\nDisciplina: {this.Disciplina}";
    }
}
