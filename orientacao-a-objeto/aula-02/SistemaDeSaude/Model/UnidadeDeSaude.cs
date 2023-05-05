namespace SistemaDeSaude.Model
{
    public class UnidadeDeSaude
    {

        public string? Nome { get; set; }
        public string? Cnpj { get; set; }
        public int Telefone { get; set; }
        public Endereco? Endereco { get; set; }
        public Funcionario? Funcionario { get; set; }
        public List<Paciente>? Pacientes { get; set; }
    }



}