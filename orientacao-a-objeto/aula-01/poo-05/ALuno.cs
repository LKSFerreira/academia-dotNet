// 2 - Criar uma classe chamada Aluno com 3 construtores, sendo que o primeiro recebe o nome e a matrícula
// do aluno, o segundo recebe apenas a data de nascimento do aluno e o terceiro construtor recebe o nome
// do aluno, a data de nascimento e o ano em que o aluno ingressou na faculdade.
// Crie uma classe principal, com 3 objetos, cada um instanciando a classe com um construtor diferente.

class Aluno
{
    private string nome;
    private int matricula;
    private DateTime dataNascimento;
    private int anoIngresso;

    public Aluno(string nome, int matricula)
    {
        this.nome = nome;
        this.matricula = matricula;
    }

    public Aluno(DateTime dataNascimento)
    {
        this.dataNascimento = dataNascimento;
    }

    public Aluno(string nome, DateTime dataNascimento, int anoIngresso)
    {
        this.nome = nome;
        this.dataNascimento = dataNascimento;
        this.anoIngresso = anoIngresso;
    }

    public override string ToString()
    {
        return $"Nome: {nome}\nMatrícula: {matricula}\nData de Nascimento: {dataNascimento}\nAno de Ingresso: {anoIngresso}";
    }
}