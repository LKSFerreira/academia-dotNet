// 11) Escreva um algoritmo para ler o número de eleitores de um município, 
// o número de votos brancos, nulos e válidos. 
// Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.

Console.WriteLine($"Digite o número de eleitores do município: ");
int numeroEleitores = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número de votos brancos: ");
int votosBrancos = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número de votos nulos: ");
int votosNulos = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número de votos válidos: ");
int votosValidos = int.Parse(Console.ReadLine()!);

double percentualVotosBrancos = (votosBrancos * 100) / numeroEleitores;
double percentualVotosNulos = (votosNulos * 100) / numeroEleitores;
double percentualVotosValidos = (votosValidos * 100) / numeroEleitores;

Console.WriteLine($"O percentual de votos brancos é: {percentualVotosBrancos.ToString("F2")}%");
Console.WriteLine($"O percentual de votos nulos é: {percentualVotosNulos.ToString("F2")}%");
Console.WriteLine($"O percentual de votos válidos é: {percentualVotosValidos.ToString("F2")}%");