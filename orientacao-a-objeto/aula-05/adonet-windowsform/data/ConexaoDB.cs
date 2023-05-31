using System.Data;
using System.Data.SqlClient;

namespace adonet_windowsform.data;

public class ConexaoDB
{
    private string _connectionString = "Data Source=localhost; Initial Catalog=adonet; User ID=atos; password=senha123;language=Portuguese";

    private SqlConnection _connection;

    private void conexao()
    {
        _connection = new SqlConnection(_connectionString);
    }

    public SqlConnection abrirConexao()
    {
        try
        {
            conexao();
            _connection.Open();
            return _connection;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void fecharConexao()
    {
        try
        {
            _connection.Close();
        }
        catch (Exception ex)
        {   
            Console.WriteLine($"Erro ao fechar a conexão: {ex.Message}");
            return;
        }
    }

    public DataTable executarConsultaGenerica(string sql)
    {
        try
        {
            abrirConexao();
            SqlCommand command = new SqlCommand(sql, _connection); // Cria o comando SQL
            command.ExecuteNonQuery(); // Executa o comando SQL
            SqlDataAdapter adapter = new SqlDataAdapter(command); // Cria o adaptador para transformar o resultado em um DataTable
            DataTable dataTable = new DataTable(); // Cria o DataTable
            adapter.Fill(dataTable); // Preenche o DataTable com o resultado da consulta
            return dataTable;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
        finally
        {
            fecharConexao();
        }
    }
}
