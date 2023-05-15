namespace Escolar_POO.Model;

public class Aluno : Pessoa
{
    public int Matricula { get; private set; }

    public Aluno(string? nome, int idade, int matricula) : base(nome, idade)
    {
        Matricula = matricula;
    }


    public override string? ToString()
    {
        return $"Nome: {this.Nome}\nIdade: {this.Idade}\nMatrícula: {this.Matricula}";
    }
}
