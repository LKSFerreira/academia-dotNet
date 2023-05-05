using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaDeSaude.Model
{
    public class Paciente
    {
        string nome;
        string cpf;
        DateTime dataNascimento;
        string telefone;
        string email;
        Endereco endereco;
        List<UnidadeDeSaude> unidadesDeSaude;   
    }
}