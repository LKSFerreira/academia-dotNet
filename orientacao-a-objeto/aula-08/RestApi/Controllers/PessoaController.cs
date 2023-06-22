using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using RestApi.Services;

namespace RestApi.Controllers;

[Authorize] // Todas os endpoints dessa controller precisam de autenticação
[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    private readonly IJWTAuthenticationManager _jwtAuthenticationManager;

    public PessoaController(IJWTAuthenticationManager jwtAuthenticationManager)
    {
        _jwtAuthenticationManager = jwtAuthenticationManager;
    }

    [AllowAnonymous] // Permite que o endpoint seja acessado sem autenticação
    // Retorna o meu nome
    [HttpGet("nome")]
    public string GetLucas()
    {
        return "Lucas";
    }

    [HttpGet("idade")]
    public int GetIdade()
    {
        return 32;
    }

    // recebe um nome e retorna uma saudação com o nome

    [HttpGet("ola/{nome}")]
    public string GetSaudacao(string nome)
    {
        return $"Olá {nome}";
    }

    [HttpGet("maioridade/{nome}/{idade}")]
    public string GetMaioridade(string nome, int idade)
    {
        return $"{nome} é {(idade >= 18 ? "maior" : "menor")} de idade";
    }

    [HttpGet("listar")]
    public async Task<IActionResult> GetAllAsync(
        [FromServices] EntityAtosContext contexto)
    {
        var pessoas = await contexto
            .Pessoas!
            .AsNoTracking()
            .ToListAsync();

        return pessoas == null ? NotFound() : Ok(pessoas);
    }

    [HttpGet("buscar/{id}")]
    public async Task<IActionResult> GetByIdAsync(
        [FromServices] EntityAtosContext contexto,
        [FromRoute] int id)
    {
        var pessoa = await contexto
            .Pessoas!
            .AsNoTracking() // Método para melhorar a performance quando é somente para leitura
            .FirstOrDefaultAsync(pessoa => pessoa.Id == id);

        return pessoa == null ? NotFound() : Ok(pessoa);
    }

    [HttpPost("cadastrar")]
    public async Task<IActionResult> PostAsync(
        [FromServices] EntityAtosContext contexto,
        [FromBody] Pessoa pessoa) // Corpo do JSON
    {
        if (!ModelState.IsValid)
            return BadRequest();

        try
        {
            await contexto.Pessoas!.AddAsync(pessoa);
            await contexto.SaveChangesAsync();

            return Created($"Pessoa/pessoas/{pessoa.Id}", pessoa);
        }
        catch (System.Exception)
        {
            return BadRequest();
        }
    }

    [HttpPut("atualizar/{id}")]
    public async Task<IActionResult> PutAsync(
        [FromServices] EntityAtosContext contexto,
        [FromBody] Pessoa pessoa, // Corpo do JSON
        [FromRoute] int id) // Vem da rota para buscar o registro
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var pessoaTemp = await contexto
            .Pessoas!
            .FirstOrDefaultAsync(pessoa => pessoa.Id == id);

        if (pessoaTemp == null)
            return NotFound("Registro não encontrado");

        try
        {
            pessoaTemp!.Nome = pessoa.Nome;
            contexto.Pessoas!.Update(pessoaTemp);
            await contexto.SaveChangesAsync();

            return Ok(pessoa);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("remover/{id}")]
    public async Task<IActionResult> RemoveByIdAsync(
        [FromServices] EntityAtosContext contexto,
        [FromRoute] int id)
    {
        var pessoa = await contexto
            .Pessoas!
            .FirstOrDefaultAsync(pessoa => pessoa.Id == id);

        if (pessoa == null)
            return NotFound("Registro não encontrado");

        try
        {
            contexto.Pessoas!.Remove(pessoa);
            await contexto.SaveChangesAsync();

            return Ok("Registro removido com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [AllowAnonymous]
    [HttpPost("autenticar")]
    public IActionResult Authenticate([FromBody] Cliente cliente)
    {
        Console.WriteLine(cliente);

        var token = _jwtAuthenticationManager.Authenticate(cliente.Usuario!, cliente.Senha!);

        if (token == "Usuário ou senha inválidos")
        {
            return Unauthorized();
        }

        return Ok(token);
    }

}
