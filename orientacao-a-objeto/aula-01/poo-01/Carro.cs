// •1 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao. Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.

// •Esses valores devem ser solicitados ao usuário, por linha de execução.

class Carro
{
    private String marca;
    private String modelo;
    private int anoFabricacao;

    public Carro(String marca, String modelo, int anoFabricacao)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.anoFabricacao = anoFabricacao;
    }

    public string Marca { get => marca; set => marca = value; }
    public string Modelo { get => modelo; set => modelo = value; }
    public int AnoFabricacao { get => anoFabricacao; set => anoFabricacao = value; }
}