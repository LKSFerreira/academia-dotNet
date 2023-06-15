using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestApi.Models;

namespace RestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PessoaController : ControllerBase
{
    // Retorna o meu nome
    [HttpGet("nome")]
    public string getLucas()
    {
        return "Lucas";
    }

    [HttpGet("idade")]
    public int getIdade()
    {
        return 32;
    }

    // recebe um nome e retorna uma saudação com o nome

    [HttpGet("ola/{nome}")]
    public string getSaudacao(string nome)
    {
        return $"Olá {nome}";
    }

    [HttpGet("maioridade/{nome}/{idade}")]
    public string getMaioridade(string nome, int idade)
    {
        return $"{nome} é {(idade >= 18 ? "maior" : "menor")} de idade";
    }

    [HttpGet("listar")]
    public async Task<IActionResult> getAllAsync(
        [FromServices] EntityAtosContext contexto)
    {
        var pessoas = await contexto
            .Pessoas
            .AsNoTracking()
            .ToListAsync();

        return pessoas == null ? NotFound() : Ok(pessoas);
    }

    [HttpGet("pessoas/{id}")]
    public async Task<IActionResult> getByIdAsync(
        [FromServices] EntityAtosContext contexto,
        [FromRoute] int id)
    {
        var pessoa = await contexto
            .Pessoas
            .AsNoTracking() // Método para melhorar a performance quando é somente para leitura
            .FirstOrDefaultAsync(pessoa => pessoa.id == id);

        return pessoa == null ? NotFound() : Ok(pessoa);
    }

    [HttpPost("cadastrar")]
    public async Task<IActionResult> postAsync(
        [FromServices] EntityAtosContext contexto,
        [FromBody] Pessoa pessoa) // Corpo do JSON
    {
        if (!ModelState.IsValid)
            return BadRequest();

        try
        {
            await contexto.Pessoas.AddAsync(pessoa);
            await contexto.SaveChangesAsync();

            return Created($"Pessoa/pessoas/{pessoa.id}", pessoa);
        }
        catch (System.Exception)
        {
            return BadRequest();
        }
    }

    [HttpPut("pessoas/{id}")]
    public async Task<IActionResult> putAsync(
        [FromServices] EntityAtosContext contexto,
        [FromBody] Pessoa pessoa, // Corpo do JSON
        [FromRoute] int id) // Vem da rota para buscar o registro
    {
        if (!ModelState.IsValid)
            return BadRequest();

        var pessoaTemp = await contexto
            .Pessoas
            .FirstOrDefaultAsync(pessoa => pessoa.id == id);

        if (pessoaTemp == null)
            return NotFound("Registro não encontrado");

        try
        {
            pessoaTemp!.nome = pessoa.nome;
            contexto.Pessoas.Update(pessoaTemp);
            await contexto.SaveChangesAsync();

            return Ok(pessoa);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpDelete("pessoas/{id}")]
    public async Task<IActionResult> removeByIdAsync(
        [FromServices] EntityAtosContext contexto,
        [FromRoute] int id)
    {
        var pessoa = await contexto
            .Pessoas
            .FirstOrDefaultAsync(pessoa => pessoa.id == id);

        if (pessoa == null)
            return NotFound("Registro não encontrado");

        try
        {
            contexto.Pessoas.Remove(pessoa);
            await contexto.SaveChangesAsync();

            return Ok("Registro removido com sucesso");
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
