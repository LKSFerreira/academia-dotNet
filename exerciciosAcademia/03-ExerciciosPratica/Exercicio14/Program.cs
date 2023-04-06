// 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a velocidade de um 
// link de Internet (em Mbps). Em seguida, calcule e informe o tempo aproximado de download 
// do arquivo usando este link (em minutos).

Console.WriteLine($"Digite o tamanho do arquivo em MB");
double tamanhoArquivo = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a velocidade da internet em Mbps");
double velocidadeInternet = double.Parse(Console.ReadLine()!);

double tempoDownload = tamanhoArquivo / (velocidadeInternet * 0.125);

int tempoEmMinutos = (int)tempoDownload / 60;
double tempoEmSegundos = ((tempoDownload / 60) - tempoEmMinutos) * 60;

Console.WriteLine($"O tempo aproximado de download é: {tempoEmMinutos} minutos e {(int)tempoEmSegundos} segundos");