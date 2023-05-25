using desafio_instituicao_wf.models.categorias;
using desafio_instituicao_wf.models.pessoas;

namespace desafio_instituicao.controllers;

public class Registro
{
    public List<Aluno> Alunos { get; } = new List<Aluno>();
    private List<Visitante> visitantes = new List<Visitante>();
    private static string caminhoDadosCSV = "./data/dados.csv";
    private static string[] dadosCSV = File.ReadAllLines(AtualizarDadosCSV());
    private bool ehAluno;

    public Registro()
    {
        carregarDadosCSV();
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
                adicionarCursoNaLista(linhaAtual);
                continue;
            }

            // Tomar uma decisão com base na primeira letra de uma linha futura
            if (linhasFuturas.Count > 0 && linhasFuturas.Peek()[0] == 'Y')
            {
                ehAluno = true;
                adicionarPessoaNaLista(ehAluno, linhaAtual);
            }
            else
            {
                ehAluno = false;
                adicionarPessoaNaLista(ehAluno, linhaAtual);
            }
        }
    }

    void adicionarPessoaNaLista(bool ehAluno, string linha)
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
            Alunos.Add(aluno);
        }
        else
        {
            Visitante visitante = new Visitante(nome, telefone, cidade, rg, cpf);
            visitantes.Add(visitante);
        }
    }

    private void adicionarCursoNaLista(string linha)
    {
        string matricula = linha.Split('-')[1];
        string codigoDoCurso = linha.Split('-')[2];
        string nomeDoCurso = linha.Split('-')[3];

        Curso curso = new Curso(matricula, codigoDoCurso, nomeDoCurso);
        Alunos.Last().AdicionarCurso(curso);
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
