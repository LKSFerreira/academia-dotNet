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

    public Pessoa(int id, string nome, string profissao)
    {
        Id = id;
        Nome = nome;
        Profissao = profissao;
    }

    public bool gravar()
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        SqlConnection sqlConnection = conexaoDB.abrirConexao();
        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();

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

    public static bool excluir(string id)
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        SqlConnection sqlConnection = conexaoDB.abrirConexao();
        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();

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

    public bool alterar()
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        SqlConnection sqlConnection = conexaoDB.abrirConexao();
        SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
        SqlCommand sqlCommand = sqlConnection.CreateCommand();

        sqlCommand.Transaction = sqlTransaction;

        sqlCommand.CommandType = System.Data.CommandType.Text;
        sqlCommand.CommandText = "update pessoas set nome = @nome, profissao = @profissao where id = @id;";

        sqlCommand.Parameters.Add("@id", System.Data.SqlDbType.Int);
        sqlCommand.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
        sqlCommand.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);
        sqlCommand.Parameters[0].Value = Id;
        sqlCommand.Parameters[1].Value = Nome;
        sqlCommand.Parameters[2].Value = Profissao;

        try
        {
            sqlCommand.ExecuteNonQuery();
            sqlTransaction.Commit();
            return true;
        }
        catch (Exception ex)
        {
            sqlTransaction.Rollback();
            throw new Exception("Erro ao atualizar o registro! " + ex.Message);
        }
        finally
        {
            conexaoDB.fecharConexao();
        }
    }

    public static Pessoa consultar(int id)
    {
        ConexaoDB conexaoDB = new ConexaoDB();

        try
        {
            SqlConnection sqlConnection = conexaoDB.abrirConexao();
            SqlCommand sqlCommand = new SqlCommand("select * from pessoas;", sqlConnection);

            sqlCommand.CommandType = System.Data.CommandType.Text;
            sqlCommand.CommandText = "select * from pessoas where id = @id;";

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                if (Convert.ToInt32(sqlDataReader["id"]) == id)
                {
                    int idPessoa = Convert.ToInt32(sqlDataReader["id"]);
                    string nome = sqlDataReader["nome"].ToString();
                    string Profissao = sqlDataReader["profissao"].ToString();

                    return new Pessoa(idPessoa, nome, Profissao);
                }
            }
            return null;
        }
        catch (Exception ex)
        {
            throw new Exception("Erro ao consultar o registro! " + ex.Message);
        }
        finally
        {
            conexaoDB.fecharConexao();
        }
    }
}
