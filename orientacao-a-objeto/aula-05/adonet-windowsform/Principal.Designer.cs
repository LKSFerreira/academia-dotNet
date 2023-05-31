using adonet_windowsform.components;
using adonet_windowsform.data;
using adonet_windowsform.model;

namespace adonet_windowsform;

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

    #region Windows Form Designer generated code

    TabelaDeDados tabelaDeDados = new TabelaDeDados(0, 190);
    Botao botaoFiltrar = new Botao("Filtrar", 550, 40);
    Botao botaoConsultar = new Botao("Consultar", 750, 40);
    Botao botaoCadastrar = new Botao("Cadastrar", 550, 105);
    Botao botaoExcluir = new Botao("Excluir", 750, 105);
    CaixaDeTexto textBoxNome = new CaixaDeTexto(10, 50);
    CaixaDeTexto textBoxProfissao = new CaixaDeTexto(10, 110);

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(1440, 940);
        this.Text = "Bem vindo ao ADO.NET";
        // Centraliza o formulario principal
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        // Desabilita o redimensionamento do formulario
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        // Altera a cor de fundo do formulario principal
        this.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
        // Desabilita o botao de maximizar
        this.MaximizeBox = false;

        // Cria um botao para filtrar no banco de dados
        this.Controls.Add(botaoFiltrar);
        botaoFiltrar.Click += new EventHandler(this.botaoFiltrar_Click);

        // Cria um botao para consultar no banco de dados
        this.Controls.Add(botaoConsultar);
        botaoConsultar.Click += new EventHandler(this.botaoConsultar_Click);

        // Cria um botao para cadastrar no banco de dados
        this.Controls.Add(botaoCadastrar);
        botaoCadastrar.Click += new EventHandler(this.botaoCadastrar_Click);

        // Cria um botao para excluir no banco de dados
        this.Controls.Add(botaoExcluir);
        botaoExcluir.Click += new EventHandler(this.botaoExcluir_Click);

        // Cria a caixa de texto para filtrar no banco de dados
        this.Controls.Add(textBoxNome);
        textBoxNome.PlaceholderText = "Nome";

        this.Controls.Add(textBoxProfissao);
        textBoxProfissao.PlaceholderText = "Profissão";

        // Cria a tabela de dados para exibir os dados do banco de dados
        this.Controls.Add(tabelaDeDados);
        consultar();
    }

    private void botaoExcluir_Click(object sender, EventArgs e)
    {
        int rowIndex = tabelaDeDados.CurrentCell.RowIndex;
        string id = tabelaDeDados.Rows[rowIndex].Cells["id"].Value.ToString();
        if (Pessoa.excluirPessoa(id)) MessageBox.Show("Pessoa excluída com sucesso!");
        consultar();
    }
    private void botaoCadastrar_Click(object sender, EventArgs e)
    {
        string nome = textBoxNome.Text;
        string profissao = textBoxProfissao.Text;

        Pessoa pessoa = new Pessoa(nome, profissao);

        if (textBoxNome.Text == "" || textBoxProfissao.Text == "")
        {
            MessageBox.Show("Preencha todos os campos!");
            if (textBoxNome.Text == "") textBoxNome.Focus();
            else textBoxProfissao.Focus();
        }
        else
        {
            if (pessoa.gravarPessoa()) MessageBox.Show("Pessoa cadastrada com sucesso!");
            textBoxNome.Text = "";
            textBoxProfissao.Text = "";
            consultar();
        }

    }

    private void botaoConsultar_Click(object sender, EventArgs e)
    {
        consultar();
    }

    private void consultar()
    {
        ConexaoDB conexaoDB = new ConexaoDB();
        string sql = "SELECT * FROM pessoas";
        var dataTable = conexaoDB.executarConsultaGenerica(sql);
        tabelaDeDados.DataSource = dataTable;

        // Altera o nome das colunas da tabela de dados
        tabelaDeDados.Columns[0].HeaderText = "ID";
        tabelaDeDados.Columns[1].HeaderText = "Nome";
        tabelaDeDados.Columns[2].HeaderText = "Profissão";
    }

    private void botaoFiltrar_Click(object sender, EventArgs e)
    {
        ConexaoDB conexaoDB = new ConexaoDB();
        string sql = "SELECT * FROM pessoas WHERE nome LIKE '%" + textBoxNome.Text + "%'";
        var dataTable = conexaoDB.executarConsultaGenerica(sql);
        tabelaDeDados.DataSource = dataTable;
    }

    #endregion
}
