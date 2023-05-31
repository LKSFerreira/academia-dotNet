using System.Data.SqlClient;
using adonet_windowsform.data;

namespace adonet_windowsform.model;

public class Pessoa
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Profissao { get; private set; }

    public Pessoa(string nome, string profissao)
    {
        Nome = nome;
        Profissao = profissao;
    }

    public bool gravarPessoa()
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        SqlConnection sqlConnection = conexaoDB.abrirConexao();
        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();

        sqlCommand.Connection = sqlConnection;
        sqlCommand.Transaction = sqlTransaction;

        sqlCommand.CommandType = System.Data.CommandType.Text;
        sqlCommand.CommandText = "insert into pessoas values (@nome, @profissao);";

        sqlCommand.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
        sqlCommand.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);
        sqlCommand.Parameters[0].Value = Nome;
        sqlCommand.Parameters[1].Value = Profissao;

        try
        {
            sqlCommand.ExecuteNonQuery();
            sqlTransaction.Commit();
            return true;
        }
        catch (Exception ex)
        {
            sqlTransaction.Rollback();
             throw new Exception("Erro ao cadastrar o registro! " + ex.Message);
        }
        finally
        {
            conexaoDB.fecharConexao();
        }
    }

    public static bool excluirPessoa(string id)
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        SqlConnection sqlConnection = conexaoDB.abrirConexao();
        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();

        sqlCommand.Connection = sqlConnection;
        sqlCommand.Transaction = sqlTransaction;

        sqlCommand.CommandType = System.Data.CommandType.Text;
        sqlCommand.CommandText = "delete from pessoas where id = @id;";

        sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
        sqlCommand.Parameters[0].Value = id;

        try
        {
            sqlCommand.ExecuteNonQuery();
            sqlTransaction.Commit();
            return true;
        }
        catch (Exception ex)
        {
            sqlTransaction.Rollback();
            throw new Exception("Erro ao excluir o registro! " + ex.Message);
        }
        finally
        {
            conexaoDB.fecharConexao();
        }
    }
}
