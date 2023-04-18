// Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número
// x lido utilizando laços de repetição, e mostre na tela.

Console.WriteLine($"Digite um valor inteiro");
int valorX = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{valorX} x {i} = {valorX * i}");
}