using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RestApi.Models;
using RestApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EntityAtosContext>();

//------------------------------------------------------------
// Cria uma variavel para armazenar uma hash de string aleatória gerada pelo RNGCryptoServiceProvider
// Esta hash será usada para criptografar o token   

// Instancia o RandomNumberGenerator
var rng = RandomNumberGenerator.Create();

// Cria um array de bytes com 32 posições
var stringChavePrivada = new byte[32];

// Preenche o array de bytes com uma hash aleatória
rng.GetBytes(stringChavePrivada);

// Converte o array de bytes para uma string
var tokenKey = Encoding.ASCII.GetString(stringChavePrivada);

// Converte a string para um array de bytes
var key = Encoding.ASCII.GetBytes(tokenKey);

// configura o jwt authentication
builder.Services.AddAuthentication(x =>
{
    // O DefaultAuthenticateScheme é o tipo de autenticação que será usado quando o usuário estiver autenticado
    // Isso significa que o usuário deve enviar o token em todas as requisições
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;

    // Já o DefaultChallengeScheme é o tipo de autenticação que será usado quando o usuário não estiver autenticado
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).AddJwtBearer(token =>
{
    // Define os parâmetros de validação do token
    // Neste caso, o token será validado com base na chave de criptografia e o algoritmo de segurança
    token.RequireHttpsMetadata = false;

    // Define se o token deve ser salvo após a validação
    token.SaveToken = true;

    // Define os parâmetros de validação do token
    token.TokenValidationParameters = new TokenValidationParameters
    {
        // Define se o token deve ser validado
        ValidateIssuerSigningKey = true,

        // Define se o emissor deve ser validado
        IssuerSigningKey = new SymmetricSecurityKey(key),

        // Define se o destinatário deve ser validado
        ValidateIssuer = false,

        // Define se o público deve ser validado
        ValidateAudience = false
    };
});

// Adiciona o serviço de autenticação, o AddSingleton é usado para que o serviço seja instanciado apenas uma vez
builder.Services.AddSingleton<IJWTAuthenticationManager>(new JWTAuthenticationManager(tokenKey));

var app = builder.Build();

//------------------------------------------------------------


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Define o uso da autenticação
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
