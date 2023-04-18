// 16 - Escreva um algoritmo que leia o placar de um jogo da primeira fase da copa do Brasil. Caso o time de fora tenha ganho o jogo por mais de 2 gols de diferença, mostre
// na tela uma mensagem indicando que o time de fora já se classificou para a próxima fase. Caso contrário, mostre uma mensagem indicando que os dois times irão se
// enfrentar novamente em um novo jogo.
// ex: time da casa 4 x 3 time de fora, mostra "Os dois times se enfrentarão em um novo jogo"
// ex2: time da casa 1 x 3 time de fora, mostra "O time de fora já se classificou"
// plus: caso ocorra um segundo jogo, leia o placar desse novo jogo e então diga quem passou de fase.


Console.WriteLine($"Digite o placar do jogo");
string placar = Console.ReadLine()!;

string[] placarSeparado = placar.Split('x');
int placarTimeCasa = int.Parse(placarSeparado[0]);
int placarTimeFora = int.Parse(placarSeparado[1]);

string resultado = Math.Abs(placarTimeCasa - placarTimeFora) >= 2 ? "O time de fora já se classificou" : "Os dois times se enfrentarão em um novo jogo";
Console.WriteLine($"{resultado}");