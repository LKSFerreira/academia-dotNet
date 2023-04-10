//Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.
//Usando o laço de repetição for.

Console.WriteLine($"Digite um valor inteiro");
int valorX = int.Parse(Console.ReadLine()!);

for (int i = 0; i <= 100; i += valorX)
{
    Console.WriteLine(i);
}
