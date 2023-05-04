Console.WriteLine($"Criar objeto do tipo Pessoa: 1 - Com nome ou 2 - Sem nome");

// Usando Switch Expression

int opcao = int.Parse(Console.ReadLine()!);

Pessoa pessoa = opcao switch
{
    1 => new Pessoa("João", 20),
    2 => new Pessoa(20),
    _ => throw new ArgumentOutOfRangeException("Opção inválida")
};

Console.WriteLine(pessoa.ToString());
