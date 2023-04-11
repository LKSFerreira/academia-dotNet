// 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
// Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
// Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
// Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
// escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
// de votos em branco. 

Console.WriteLine($"Para votar nos candidatos digite o nome: JOAO ou ZECA");
Console.WriteLine($"Caso queira votar em branco digite BRANCO");
Console.WriteLine($"Caso queira encerrar a votação digite FIM");

int votosJoao = 0;
int votosZeca = 0;
int votosBrancos = 0;

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
    }

} while (true);

Console.WriteLine($"O número de votos para o candidato JOAO foi: {votosJoao}");
Console.WriteLine($"O número de votos para o candidato ZECA foi: {votosZeca}");
Console.WriteLine($"O número de votos em branco foi: {votosBrancos}");
