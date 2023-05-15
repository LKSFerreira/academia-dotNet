namespace Veiculo_POO.Model;

public abstract class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public virtual void Ligar()
    {
        Console.Write("Ligando o veículo");
        for (int i = 0; i < 3; i++)
        {
            Thread.Sleep(333);
            Console.Write($". ");
        }
        Console.WriteLine();
    }

    public void Dirigindo()
    {
        Console.WriteLine($"Dirigindo o veículo {Modelo} da {Marca}");
    }
}
