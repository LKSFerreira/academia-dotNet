using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace RestApi.Services;

public interface IJWTAuthenticationManager
{
    string Authenticate(string usuario, string senha);
}

public class JWTAuthenticationManager : IJWTAuthenticationManager
{
    private readonly Dictionary<string, string> _usuarios = new()
    {
        {"teste","teste123"},
        {"lksferreira","lks123"}
    };

    private readonly string tokenKey;

    public JWTAuthenticationManager(string tokenKey)
    {
        this.tokenKey = tokenKey;
    }

    public string Authenticate(string usuario, string senha)
    {   
        // Verifica se o usuário e senha passados estão corretos de acordo com o local de armazenamento, neste caso um dicionário
        if (!_usuarios.Any(usuarios => usuarios.Key == usuario && usuarios.Value == senha))
        {
            return "Usuário ou senha inválidos";
        }

        // Instancia do tokenHandler JwtSecurityTokenHandler que ser para criar e validar o token
        var tokenHandler = new JwtSecurityTokenHandler();

        // Instancia do tokenKey que ser para criptografar o token
        var tokenKey = Encoding.ASCII.GetBytes(this.tokenKey);

        // Instancia do SecurityTokenDescriptor que ser para criar o token        
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            // Definindo os dados do token
            Subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, usuario)
            }),

            // Definindo o tempo de expiração do token
            Expires = DateTime.UtcNow.AddHours(2),

            // Definindo a chave de criptografia e o algoritmo de segurança
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
        };

        // Cria o token com base nas informações definidas no tokenDescriptor
        var token = tokenHandler.CreateToken(tokenDescriptor);

        // Escreve o token para ser consumido
        return tokenHandler.WriteToken(token);
    }
}
