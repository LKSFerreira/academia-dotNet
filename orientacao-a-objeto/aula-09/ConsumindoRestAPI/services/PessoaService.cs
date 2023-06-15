using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using ConsumindoRestAPI.models;
using Newtonsoft.Json;

namespace ConsumindoRestAPI.services;

public class PessoaService
{
    private static List<Pessoa>? pessoas;

    private static async Task<List<Pessoa>> getListar()
    {
        try
        {
            HttpClient client = requisicaoAPI();
            var response = await client.GetAsync(client.BaseAddress + "pessoa/listar"); // Faz a requisição GET
            var pessoasJsonString = response.Content.ReadAsStringAsync().Result;
            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoasJsonString);

            return pessoas ?? new List<Pessoa>();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message + " | " + ex.InnerException?.Message);
        }
    }

    public void listar()
    {
        if (getListar().Result.Count > 0)
            pessoas!.ForEach(pessoa => Console.WriteLine($"{pessoa}"));
        else
            Console.WriteLine($"Nenhuma pessoa cadastrada");
    }

    private static HttpClient requisicaoAPI()
    {
        HttpClient client = new HttpClient(); // Instancia o client para fazer a requisição
        client.BaseAddress = new Uri("https://localhost:7008"); // Define a URL base da API
        client.DefaultRequestHeaders.Accept.Clear(); // Limpa o cabeçalho de aceitação
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Define o tipo de conteúdo aceito
        return client;
    }

    public async void cadastrar()
    {
        Console.WriteLine($"Informe o nome da pessoa:");
        string nome = Console.ReadLine()!;

        HttpClient client = requisicaoAPI();

        // Necessario importar o PostAsJsonAsync pois não se trata de um método padrão do HttpClient
        var response = await client.PostAsJsonAsync(client.BaseAddress + "pessoa/cadastrar", new Pessoa(nome));// Faz a requisição POST

        // Usando if ternário
        Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "cadastrada com sucesso" : $"não cadastrada. Erro: {response.StatusCode}")} ");
        pessoas = getPessoasList().Result;
    }

    private static async Task<List<Pessoa>> getPessoasList()
    {
        HttpClient client = requisicaoAPI();

        var response = await client.GetAsync(client.BaseAddress + "pessoa/listar"); // Faz a requisição GET

        var pessoasJsonString = response.Content.ReadAsStringAsync().Result;
        pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoasJsonString);
        return pessoas ?? new List<Pessoa>();
    }

    public async void atualizar()
    {
        getPessoasList().Wait();

        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        // Verifica se o id informado existe na lista de pessoas
        if (pessoas!.Find(pessoa => pessoa.id == id) == null)
        {
            Console.WriteLine($"Pessoa não encontrada");
        }
        else
        {
            Console.WriteLine($"Informe o novo nome da pessoa:");
            string nome = Console.ReadLine()!;

            HttpClient client = requisicaoAPI();
            // Necessario importar o PutAsJsonAsync pois não se trata de um método padrão do HttpClient    
            var response = await client.PutAsJsonAsync(client.BaseAddress + $"pessoa/atualizar/{id}", new Pessoa(nome));// Faz a requisição PUT

            Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "atualizada com sucesso" : $"não atualizada. Erro: {response.StatusCode}")} ");
        }
    }

    /// <summary> Remove uma pessoa. </summary>
    /// <remarks> Caso a pessoa tenha algum e-mail vinculado por chave estrangeira, não será possível remover. 
    /// O código de retorno será um bad request (400).</remarks>
    public async void remover()
    {
        getPessoasList().Wait();

        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        // Verifica se o id informado existe na lista de pessoas
        if (pessoas!.Find(pessoa => pessoa.id == id) == null)
        {
            Console.WriteLine($"Pessoa não encontrada");
        }
        else
        {
            HttpClient client = requisicaoAPI();

            var response = await client.DeleteAsync(client.BaseAddress + $"pessoa/remover/{id}"); // Faz a requisição DELETE

            Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "removida com sucesso" : $"não removida. Erro: {response.StatusCode}")} ");
        }
    }

    public void buscarPorId()
    {
        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        getListar().Wait();

        // Por meio de uma expressão lambda, busca a pessoa na lista pelo ID
        Console.WriteLine($"{pessoas!.Find(pessoa => pessoa.id == id) ?? new Pessoa("Pessoa não encontrada")}");
    }
}
