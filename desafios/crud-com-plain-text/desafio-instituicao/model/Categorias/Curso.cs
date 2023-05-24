namespace desafio_instituicao.model.Categorias;

public class Curso
{
    public string Matricula { get; }
    public string CodigoDoCurso { get; }
    public string NomeDoCurso { get; }

    public Curso(string matricula, string codigoDoCurso, string nomeDoCurso)
    {
        Matricula = matricula;
        CodigoDoCurso = codigoDoCurso;
        NomeDoCurso = nomeDoCurso;
    }

    public override string ToString()
    {
        return $"Matricula: {Matricula,-10} | Codigo do Curso: {CodigoDoCurso,-3} | Nome do Curso: {NomeDoCurso,-10}";
    }
}
