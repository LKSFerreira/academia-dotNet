using desafio_instituicao.model.Categorias;

namespace desafio_instituicao.model.Pessoas;

public class Aluno : Pessoa
{
    private List<Curso> cursos = new List<Curso>();
    public Aluno(string nome, string telefone, string cidade, string rg, string cpf) : base(nome, telefone, cidade, rg, cpf) { }
    public void AdicionarCurso(Curso curso)
    {
        cursos.Add(curso);
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        string cursosStr = string.Join(" | ", cursos.Select(curso => curso.ToString()));
        return $"Titular: {Nome,-20} | Telefone: {Telefone,-11} | Cidade: {Cidade,-15} | CPF: {Cpf,-12} | RG: {Rg,-12}\nCursos: {cursosStr}\n";
    }
}

