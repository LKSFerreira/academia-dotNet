using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDBFirst.Models;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; }

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();


    public static bool adicionar()
    {
        try
        {
            Console.WriteLine("Insera o nome da pessoa:");
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = Console.ReadLine()!;

            //modo 1
            Console.WriteLine("Insira um email:");
            string emailTemp = Console.ReadLine()!;

            pessoa.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                Email1 = emailTemp
                            }
                        };
            //modo 2
            //Email e = new Email();
            //Console.WriteLine("Insira um email:");
            //e.email = Console.ReadLine();
            //p.emails = new List<Email>();
            //p.emails.Add(e);

            DbfirstContext contexto = new DbfirstContext();

            contexto.Pessoas.Add(pessoa);
            contexto.SaveChanges();

            Console.WriteLine("Adicionado registro com sucesso!");
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool alterar()
    {
        try
        {

            Console.WriteLine($"Digite o ID da pessoa que deseja alterar o nome:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            DbfirstContext contexto = new DbfirstContext();
            Pessoa pessoa = contexto.Pessoas.Find(idPessoa);

            Console.WriteLine($"Digite o novo nome da pessoa:");
            pessoa!.Nome = Console.ReadLine()!;

            contexto.Pessoas.Update(pessoa);
            contexto.SaveChanges();

            Console.WriteLine($"Nome alterado com sucesso!");
            return true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static bool adicionarEmail()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja adicionar um email:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            DbfirstContext contexto = new DbfirstContext();
            Pessoa pessoa = contexto.Pessoas.Find(idPessoa);

            Console.WriteLine($"Digite o email da pessoa:");
            Email novoEmail = new Email();
            novoEmail.Email1 = Console.ReadLine()!;

            pessoa!.Emails!.Add(novoEmail);
            contexto.Pessoas.Update(pessoa);
            contexto.SaveChanges();

            Console.WriteLine($"Email adicionado com sucesso!");
            return true;
        }
        catch (System.Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    internal static bool excluir()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja excluir:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            DbfirstContext contexto = new DbfirstContext();
            Pessoa pessoa = contexto.Pessoas.Find(idPessoa);

            Console.WriteLine($"Nome: {pessoa!.Nome}");
            Console.WriteLine($"Emails:");
            foreach (var email in pessoa!.Emails!)
            {
                Console.WriteLine($"\t {email.Email1}");
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

    internal static bool consultar()
    {
        try
        {
            List<Pessoa> pessoas = (from Pessoa pessoa in new DbfirstContext().Pessoas select pessoa)
                .Include(pessoa => pessoa.Emails)
                .ToList<Pessoa>();

            pessoas.ForEach(pessoa =>
            {
                Console.WriteLine($"ID: {pessoa.Id}");
                Console.WriteLine($"Nome: {pessoa.Nome}");
                Console.WriteLine($"Emails:");
                foreach (var email in pessoa.Emails!)
                {
                    Console.WriteLine($"\t {email.Email1}");
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

    internal static bool consultarPorId()
    {
        try
        {
            Console.WriteLine($"Digite o ID da pessoa que deseja consultar:");
            int idPessoa = int.Parse(Console.ReadLine()!);

            // O método Find() só funciona para a chave primária da tabela
            // DbfirstContext contexto = new DbfirstContext();
            // Pessoa? pessoa = contexto.Pessoas.Find(idPessoa);

            // Console.WriteLine($"ID: {pessoa!.id}");
            // Console.WriteLine($"Nome: {pessoa!.nome}");
            // Console.WriteLine($"Emails:");
            // foreach (var email in pessoa!.emails!)
            // {
            //     Console.WriteLine($"\t {email.email}");
            // }

            Pessoa pessoa = new DbfirstContext().Pessoas
                .Include(pessoa => pessoa.Emails)
                .FirstOrDefault()!;

            Console.WriteLine($"ID: {pessoa.Id}");
            Console.WriteLine($"Nome: {pessoa.Nome}");
            Console.WriteLine($"Emails:");
            foreach (var email in pessoa.Emails!)
            {
                Console.WriteLine($"\t {email.Email1}");
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