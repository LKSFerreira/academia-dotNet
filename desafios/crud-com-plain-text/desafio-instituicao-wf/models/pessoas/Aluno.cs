
using desafio_instituicao_wf.models.categorias;

namespace desafio_instituicao_wf.models.pessoas;

public class Aluno : Pessoa
{
    public List<Curso> Cursos { get; } = new List<Curso>();
    public Aluno(string nome, string telefone, string cidade, string rg, string cpf) : base(nome, telefone, cidade, rg, cpf) { }
    public void AdicionarCurso(Curso curso)
    {
        Cursos.Add(curso);
    }

    public override string ToString()
    {
        string cursosStr = string.Join(" | ", Cursos.Select(curso => curso.ToString()));
        return $"Titular: {Nome,-20} | Telefone: {Telefone,-11} | Cidade: {Cidade,-15} | CPF: {Cpf,-1} | RG: {Rg,-12} Cursos: {cursosStr}\n";
    }
}

