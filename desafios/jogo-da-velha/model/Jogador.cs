using System.Security.Cryptography;
using System.Text;

public class Jogador
{
    public string HashJogador { get; set; }
    public string Nome { get; set; }
    public int QuantidadePartidas { get; set; }
    public int Vitorias { get; set; }
    public int Derrotas { get; set; }
    public int Empates { get; set; }

    public Jogador(string nome)
    {
        HashJogador = criaHashDoJogador(nome);
        this.Nome = nome;
        QuantidadePartidas = 0;
        Vitorias = 0;
        Derrotas = 0;
        Empates = 0;
    }

    private string criaHashDoJogador(string nome)
    {
        // Converte a string para um array de bytes
        byte[] bytes = Encoding.ASCII.GetBytes(nome);

        // Converte a string para um array de bytes
        SHA256 sha256 = SHA256.Create();

        // Calcula o hash dos bytes usando SHA256
        byte[] hashBytes = sha256.ComputeHash(bytes);

        // Converte e retorna o hash de bytes para uma string hexadecimal
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
    }



}