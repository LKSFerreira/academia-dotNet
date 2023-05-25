using desafio_instituicao.controllers;
using desafio_instituicao_wf.components;
using desafio_instituicao_wf.models.pessoas;

namespace desafio_instituicao_wf;

partial class Principal
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    TabelaDeDados tabelaDeDados = new TabelaDeDados(0, 190);
    Botao botaoListar = new Botao("Listar", 508, 50);
    Botao botaoSair = new Botao("Sair", 757, 50);

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1440, 940);
        this.Text = "Sistema UFN";
        // Centraliza o formulario principal
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        // Desabilita o redimensionamento do formulario
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        // Altera a cor de fundo do formulario principal
        this.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);

        // Cria um botao para cadastrar uma instituicao

        this.Controls.Add(botaoListar);
        botaoListar.Click += new EventHandler(this.botaoListar_Click);

        // Cria um botao para sair da aplicacao

        this.Controls.Add(botaoSair);
        botaoSair.Click += new EventHandler(this.botaoSair_Click);


        this.Controls.Add(tabelaDeDados);
        tabelaDeDados.ColumnCount = 8;
        this.tabelaDeDados.Columns[0].Name = "Nome";
        this.tabelaDeDados.Columns[1].Name = "Telefone";
        this.tabelaDeDados.Columns[2].Name = "Cidade";
        this.tabelaDeDados.Columns[3].Name = "RG";
        this.tabelaDeDados.Columns[4].Name = "CPF";
        this.tabelaDeDados.Columns[5].Name = "Matricula";
        this.tabelaDeDados.Columns[6].Name = "Cod. Curso";
        this.tabelaDeDados.Columns[7].Name = "Nome do Curso";
    }

    Registro registro = new Registro();

    private void botaoListar_Click(object sender, EventArgs e)
    {
        // Preenche a tabela com os dados da lista alunos da classe Registro
        tabelaDeDados.Rows.Clear();
        foreach (var aluno in registro.Alunos)
        {
            tabelaDeDados.Rows.Add(aluno.Nome, aluno.Telefone, aluno.Cidade, aluno.Rg, aluno.Cpf, aluno.Cursos[0].Matricula, aluno.Cursos[0].CodigoDoCurso, aluno.Cursos[0].NomeDoCurso);
        }
    }

    private void botaoSair_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    #endregion
}
