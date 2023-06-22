using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Services;

public class PessoaService
{
    public static bool Adicionar()
    {
        try
        {
            Console.WriteLine("Insera o nome da pessoa:");
            Pessoa pessoa = new()
            {
                Nome = Console.ReadLine()!
            };

            //modo 1
            Console.WriteLine("Insira um email:");
            string emailTemp = Console.ReadLine()!;

            pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };
            //modo 2
            //Email e = new Email();
            //Console.WriteLine("Insira um email:");
            //e.email = Console.ReadLine();
            //p.emails = new List<Email>();
            //p.emails.Add(e);

            EntityAtosContext contexto = new();

            contexto.Pessoas!.Add(pessoa);
            contexto.SaveChanges();

            Console.WriteLine("Adicionado registro com sucesso!");
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool Alterar()
    {
        try
        {

            Console.WriteLine($"Digite o ID da pessoa que deseja alterar o nome:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            EntityAtosContext contexto = new();
            Pessoa pessoa = contexto.Pessoas!.Find(idPessoa)!;

            Console.WriteLine($"Digite o novo nome da pessoa:");
            pessoa!.Nome = Console.ReadLine()!;

            contexto.Pessoas!.Update(pessoa);
            contexto.SaveChanges();

            Console.WriteLine($"Nome alterado com sucesso!");
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool AdicionarEmail()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja adicionar um email:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            EntityAtosContext contexto = new();
            Pessoa pessoa = contexto.Pessoas!.Find(idPessoa)!;

            Console.WriteLine($"Digite o email da pessoa:");
            Email novoEmail = new()
            {
                email = Console.ReadLine()!
            };

            pessoa!.Emails!.Add(novoEmail);
            contexto.Pessoas!.Update(pessoa);
            contexto.SaveChanges();

            Console.WriteLine($"Email adicionado com sucesso!");
            return true;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool Excluir()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja excluir:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            EntityAtosContext contexto = new();
            Pessoa pessoa = contexto.Pessoas!.Find(idPessoa)!;

            Console.WriteLine($"Nome: {pessoa!.Nome}");
            Console.WriteLine($"Emails:");
            foreach (var email in pessoa!.Emails!)
            {
                Console.WriteLine($"\t {email.email}");
            }

            Console.WriteLine();

            Console.WriteLine($"Digite 'excluir' para confirmar:");
            string confirmacao = Console.ReadLine()!;
            if (confirmacao != "excluir")
            {
                Console.WriteLine($"Exclusão cancelada!");
                return false;
            }

            contexto.Pessoas.Remove(pessoa!);
            contexto.SaveChanges();

            return true;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool Consultar()
    {
        try
        {
            List<Pessoa> pessoas = (from Pessoa pessoa in new EntityAtosContext().Pessoas! select pessoa)
                .Include(pessoa => pessoa.Emails)
                .ToList<Pessoa>();

            pessoas.ForEach(pessoa =>
            {
                Console.WriteLine($"ID: {pessoa.Id}");
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Emails:");
                foreach (var email in pessoa.Emails!)
                {
                    Console.WriteLine($"\t {email.email}");
                }
                Console.WriteLine();
            });

            return true;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool ConsultarPorId()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja consultar:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            // O método Find() só funciona para a chave primária da tabela
            // EntityAtosContext contexto = new EntityAtosContext();
            // Pessoa! pessoa = contexto.Pessoas.Find(idPessoa);

            // Console.WriteLine($"ID: {pessoa!.id}");
            // Console.WriteLine($"Nome: {pessoa!.nome}");
            // Console.WriteLine($"Emails:");
            // foreach (var email in pessoa!.emails!)
            // {
            //     Console.WriteLine($"\t {email.email}");
            // }

            Pessoa pessoa = new EntityAtosContext().Pessoas!
                .Include(pessoa => pessoa.Emails)
                .FirstOrDefault()!;

            Console.WriteLine($"ID: {pessoa.Id}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Emails:");
            foreach (var email in pessoa.Emails!)
            {
                Console.WriteLine($"\t {email.email}");
            }

            Console.WriteLine();
            return true;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

}
