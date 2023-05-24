using desafio_instituicao.model.Categorias;
using desafio_instituicao.model.Pessoas;

namespace desafio_instituicao.controllers;

public class Registro
{
    private List<Aluno> alunos = new List<Aluno>();
    private List<Visitante> visitantes = new List<Visitante>();
    private static string caminhoDadosCSV = "./data/dados.csv";
    private static string[] dadosCSV = File.ReadAllLines(AtualizarDadosCSV());
    private bool ehAluno;

    public Registro()
    {
        carregarDadosCSV();
    }

    public void Listar()
    {
        listarAlunos();
        listarVisitantes();
    }

    private void carregarDadosCSV()
    {
        AtualizarDadosCSV();

        var linhasFuturas = new Queue<string>(File.ReadLines(caminhoDadosCSV));

        while (linhasFuturas.Count > 0)
        {
            var linhaAtual = linhasFuturas.Dequeue();

            if (linhaAtual[0] == 'X') continue;
            if (linhaAtual[0] == 'Y')
            {
                cadastrarCurso(linhaAtual);
                continue;
            }

            // Tomar uma decisão com base na primeira letra de uma linha futura
            if (linhasFuturas.Count > 0 && linhasFuturas.Peek()[0] == 'Y')
            {
                ehAluno = true;
                cadatrarPessoa(ehAluno, linhaAtual);
            }
            else
            {
                ehAluno = false;
                cadatrarPessoa(ehAluno, linhaAtual);
            }
        }
    }

    private void listarVisitantes()
    {
        visitantes.ForEach(visitante => Console.WriteLine(visitante));
        Console.WriteLine($"Total de visitantes: {visitantes.Count}");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
    }

    private void listarAlunos()
    {
        alunos.ForEach(aluno => Console.WriteLine(aluno));
        Console.WriteLine($"Total de alunos: {alunos.Count}");
        Console.WriteLine($"-----------------------------------------------------------------------------------------------------------------------");
    }

    void cadatrarPessoa(bool ehAluno, string linha)
    {
        string nome = "", telefone = "", cidade = "", rg = "", cpf = "";

        nome = linha.Split('-')[1];
        telefone = linha.Split('-')[2];
        cidade = linha.Split('-')[3];
        rg = linha.Split('-')[4];
        cpf = linha.Split('-')[5];

        if (ehAluno)
        {
            Aluno aluno = new Aluno(nome, telefone, cidade, rg, cpf);
            alunos.Add(aluno);
        }
        else
        {
            Visitante visitante = new Visitante(nome, telefone, cidade, rg, cpf);
            visitantes.Add(visitante);
        }
    }

    private void cadastrarCurso(string linha)
    {
        string matricula = linha.Split('-')[1];
        string codigoDoCurso = linha.Split('-')[2];
        string nomeDoCurso = linha.Split('-')[3];

        Curso curso = new Curso(matricula, codigoDoCurso, nomeDoCurso);
        alunos.Last().AdicionarCurso(curso);
    }

    private static string AtualizarDadosCSV()
    {
        if (!File.Exists(caminhoDadosCSV))
        {
            FileStream fileStream = File.Create(caminhoDadosCSV);
            fileStream.Close();
            StreamWriter credenciaisStream = new StreamWriter(caminhoDadosCSV, true);
        }
        else
        {
            dadosCSV = File.ReadAllLines(caminhoDadosCSV);
            
        }
        return caminhoDadosCSV;
    }
}
