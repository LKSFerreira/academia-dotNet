// 10) Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
// para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
// realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
// notas de menor valor fossem distribuídas em número mínimo possível. 
// Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00, uma nota de R$ 20,00,
// uma nota de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
// Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
// de acordo com o critério da “distribuição ótima”.

Console.WriteLine($"Digite o valor da quantia solicitada: ");
int valorQuantiaSolicitada = int.Parse(Console.ReadLine()!);

int valorNota100 = valorQuantiaSolicitada / 100;
int valorNota50 = (valorQuantiaSolicitada % 100) / 50;
int valorNota20 = ((valorQuantiaSolicitada % 100) % 50) / 20;
int valorNota10 = (((valorQuantiaSolicitada % 100) % 50) % 20) / 10;
int valorNota5 = ((((valorQuantiaSolicitada % 100) % 50) % 20) % 10) / 5;
int valorNota2 = (((((valorQuantiaSolicitada % 100) % 50) % 20) % 10) % 5) / 2;
int valorNota1 = ((((((valorQuantiaSolicitada % 100) % 50) % 20) % 10) % 5) % 2) / 1;

Console.WriteLine($"O valor da nota de R$ 100,00 é: {valorNota100}");
Console.WriteLine($"O valor da nota de R$ 50,00 é: {valorNota50}");
Console.WriteLine($"O valor da nota de R$ 20,00 é: {valorNota20}");
Console.WriteLine($"O valor da nota de R$ 10,00 é: {valorNota10}");
Console.WriteLine($"O valor da nota de R$ 5,00 é: {valorNota5}");
Console.WriteLine($"O valor da nota de R$ 2,00 é: {valorNota2}");
Console.WriteLine($"O valor da nota de R$ 1,00 é: {valorNota1}");

Console.WriteLine($"==================================================");
Console.WriteLine($"O valor total é: {valorQuantiaSolicitada.ToString("C")}");
Console.WriteLine($"==================================================");