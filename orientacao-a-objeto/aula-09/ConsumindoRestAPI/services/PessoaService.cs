using System.Net.Http.Headers;
using System.Text;
using ConsumindoRestAPI.models;
using Newtonsoft.Json;

namespace ConsumindoRestAPI.services;

public class PessoaService
{
    private static List<Pessoa>? pessoas;

    private static async Task<List<Pessoa>> getLista()
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
        if (getLista().Result.Count > 0)
        {
            pessoas!.ForEach(pessoa => Console.WriteLine($"{pessoa}"));
        }
        else
        {
            Console.WriteLine($"Nenhuma pessoa cadastrada");
        }
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

        var content = new StringContent(JsonConvert.SerializeObject(new Pessoa(nome)), Encoding.UTF8, "application/json"); // Define o conteúdo da requisição
        var response = await client.PostAsync(client.BaseAddress + "pessoa/cadastrar", content);// Faz a requisição POST

        // Usando if ternário
        Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "cadastrada com sucesso" : "não cadastrada")} ");
        pessoas = getPessoas().Result;
    }

    private static async Task<List<Pessoa>> getPessoas()
    {
        HttpClient client = requisicaoAPI();

        var response = await client.GetAsync(client.BaseAddress + "pessoa/listar"); // Faz a requisição GET

        var pessoasJsonString = response.Content.ReadAsStringAsync().Result;
        pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoasJsonString);
        return pessoas ?? new List<Pessoa>();
    }

    public async void atualizar()
    {
        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        // Verifica se o id informado existe na lista de pessoas
        if (pessoas!.Find(pessoa => pessoa.id == id) == null)
        {
            Console.WriteLine($"Pessoa não encontrada");
        }
        else
        {
            Console.WriteLine($"Informe o nome da pessoa:");
            string nome = Console.ReadLine()!;
            Pessoa pessoa = new Pessoa(nome);

            HttpClient client = requisicaoAPI();
            var content = new StringContent(JsonConvert.SerializeObject(pessoa), Encoding.UTF8, "application/json"); // Define o conteúdo da requisição
            var response = await client.PutAsync(client.BaseAddress + $"pessoa/{id}", content);// Faz a requisição PUT

            Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "atualizada com sucesso" : "não atualizada")} ");
        }
    }
}
