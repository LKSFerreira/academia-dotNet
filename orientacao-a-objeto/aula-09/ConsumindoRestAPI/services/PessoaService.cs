using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using ConsumindoRestAPI.models;
using Newtonsoft.Json;

namespace ConsumindoRestAPI.services;

public class PessoaService
{

    private static HttpClient RequisicaoAPI()
    {
        HttpClient client = new()
        {
            BaseAddress = new Uri("https://localhost:7008/pessoa/") // Define a URL base da API
        }; // Instancia o client para fazer a requisição
        client.DefaultRequestHeaders.Accept.Clear(); // Limpa o cabeçalho de aceitação
        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // Define o tipo de conteúdo aceito
        return client;
    }

    private static async Task<List<Pessoa>> GetListar()
    {
        try
        {
            HttpClient client = RequisicaoAPI();
            var response = await client.GetAsync(client.BaseAddress + "pessoa/listar"); // Faz a requisição GET
            var pessoasJsonString = response.Content.ReadAsStringAsync().Result;

            return response.IsSuccessStatusCode ?
            JsonConvert.DeserializeObject<List<Pessoa>>(pessoasJsonString)! : throw new Exception($"Erro: {response.StatusCode}");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public static void Listar()
    {
        try
        {
            GetListar().Result.ForEach(Console.WriteLine);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao listar pessoas: {ex.Message}");
        }
    }



    public static async void Cadastrar()
    {
        Console.WriteLine($"Informe o nome da pessoa:");
        string nome = Console.ReadLine()!;

        HttpClient client = RequisicaoAPI();

        // Necessario importar o PostAsJsonAsync pois não se trata de um método padrão do HttpClient
        var response = await client.PostAsJsonAsync(client.BaseAddress + "cadastrar", new Pessoa(nome));// Faz a requisição POST

        // Usando if ternário
        Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "cadastrada com sucesso" : $"não cadastrada. Erro: {response.StatusCode}")} ");
    }

    public static async void Atualizar()
    {
        GetListar().Wait();

        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        // Verifica se o id informado existe na lista de pessoas
        if (GetListar().Result.Find(pessoa => pessoa.Id == id) == null)
        {
            Console.WriteLine($"Pessoa não encontrada");
        }
        else
        {
            Console.WriteLine($"Informe o novo nome da pessoa:");
            string nome = Console.ReadLine()!;

            HttpClient client = RequisicaoAPI();
            // Necessario importar o PutAsJsonAsync pois não se trata de um método padrão do HttpClient    
            var response = await client.PutAsJsonAsync(client.BaseAddress + $"atualizar/{id}", new Pessoa(nome));// Faz a requisição PUT

            Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "atualizada com sucesso" : $"não atualizada. Erro: {response.StatusCode}")} ");
        }
    }

    /// <summary> Remove uma pessoa. </summary>
    /// <remarks> Caso a pessoa tenha algum e-mail vinculado por chave estrangeira, não será possível remover. 
    /// O código de retorno será um bad request (400).</remarks>
    public static async void Remover()
    {
        GetListar().Wait();

        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        // Verifica se o id informado existe na lista de pessoas
        if (GetListar().Result.Find(pessoa => pessoa.Id == id) == null)
        {
            Console.WriteLine($"Pessoa não encontrada");
        }
        else
        {
            HttpClient client = RequisicaoAPI();

            var response = await client.DeleteAsync(client.BaseAddress + $"remover/{id}"); // Faz a requisição DELETE

            Console.WriteLine($"Pessoa {(response.IsSuccessStatusCode ? "removida com sucesso" : $"não removida. Erro: {response.StatusCode}")} ");
        }
    }

    public static void BuscarPorId()
    {
        Console.WriteLine($"Informe o id da pessoa:");
        int id = int.Parse(Console.ReadLine()!);

        GetListar().Wait();

        // Por meio de uma expressão lambda, busca a pessoa na lista pelo ID
        Console.WriteLine($"{GetListar().Result.Find(pessoa => pessoa.Id == id) ?? new Pessoa("Pessoa não encontrada")}");
    }

    public static string SolicitarToken()
    {
        Console.WriteLine($"Informe seu usuário:");
        string usuario = "lksferreira"; // Console.ReadLine()!;
        Console.WriteLine($"Informe sua senha:");
        string senha = "lks123"; // Console.ReadLine()!;

        HttpClient client = RequisicaoAPI();
        // Necessario importar o PostAsJsonAsync pois não se trata de um método padrão do HttpClient
        var response = client.PostAsJsonAsync(client.BaseAddress + "autenticar", new Acesso(usuario, senha)).Result;// Faz a requisição POST
        Console.WriteLine();

        if (response.IsSuccessStatusCode)
        {
            var token = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine($"Token: {token}");
            return token.Replace("\\", "").Replace("\"", "");
        }
        else
        {
            Console.WriteLine($"Usuário ou senha inválidos");
            return "";
        }

    }

    internal static void ConsumirAPIComToken(string token)
    {
        HttpClient client = RequisicaoAPI();

        // Define o token Bearer no cabeçalho da requisição
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = client.GetAsync(client.BaseAddress + "listar").Result; // Faz a requisição GET

        if (response.IsSuccessStatusCode)
        {
            var pessoasJsonString = response.Content.ReadAsStringAsync().Result;
            var pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(pessoasJsonString);

            pessoas!.ForEach(pessoa => Console.WriteLine($"{pessoa}"));
        }
        else
        {
            Console.WriteLine($"Erro: {response.StatusCode}");
        }
    }
}
