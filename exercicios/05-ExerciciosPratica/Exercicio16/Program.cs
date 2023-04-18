// 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
// multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
// (N*3; N*3*3; N*3*3*3; etc).

Console.WriteLine($"Digite um número menor ou igual a 50: ");
int numero = int.Parse(Console.ReadLine()!);

int produto = numero;
string mensagemDoProduto = $"*3";

while (produto < 250)
{
    produto *= 3;
    Console.WriteLine($"N{mensagemDoProduto} = {produto}");
    mensagemDoProduto += $"*3";
}


