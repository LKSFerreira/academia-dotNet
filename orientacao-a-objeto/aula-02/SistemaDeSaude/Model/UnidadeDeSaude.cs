namespace SistemaDeSaude.Model
{
    public class UnidadeDeSaude
    {
        string nome;
        string cnpj;
        Endereco endereco;
        int telefone;
        string email;
        List<Paciente> pacientes;
    }
}