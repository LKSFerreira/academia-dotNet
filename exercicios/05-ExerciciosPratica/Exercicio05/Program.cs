// 5. Modifique o programa em VS anterior para aceitar votos nulos 
// (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
// Ao final, informe o nome do candidato vencedor, o número de votos nulos 
// e o número de pessoas que votaram.


Console.WriteLine($"Para votar nos candidatos digite o nome: JOAO ou ZECA");
Console.WriteLine($"Caso queira votar em branco digite BRANCO");
Console.WriteLine($"Caso queira encerrar a votação digite FIM");

int votosJoao = 0;
int votosZeca = 0;
int votosBrancos = 0;
int votosNulos = 0;

do
{
    Console.WriteLine($"Digite o nome do candidato: ");
    string nomeCandidato = Console.ReadLine()!;

    if (nomeCandidato == "FIM")
    {
        break;
    }

    switch (nomeCandidato)
    {
        case "JOAO":
            Console.WriteLine($"Você votou no candidato JOAO");
            votosJoao++;
            break;
        case "ZECA":
            Console.WriteLine($"Você votou no candidato ZECA");
            votosZeca++;
            break;
        case "BRANCO":
            Console.WriteLine($"Você votou em branco");
            votosBrancos++;
            break;
        default:
            Console.WriteLine($"Você digitou um nome inválido");
            votosNulos++;
            break;
    }

} while (true);

Console.WriteLine($"O número de votos para o candidato JOAO foi: {votosJoao}");
Console.WriteLine($"O número de votos para o candidato ZECA foi: {votosZeca}");
Console.WriteLine($"O número de votos em branco foi: {votosBrancos}");
Console.WriteLine($"O número de votos nulos foi: {votosNulos}");
