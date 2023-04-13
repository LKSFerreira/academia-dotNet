// 12.	Faça um algoritmo que leia um vetor V de 10 posições e, após, verifica se um número N, fornecido pelo usuário, existe no vetor. Se existir, indicar a(s) posição(ões), senão escrever a mensagem "O número fornecido não existe no vetor!".

Console.WriteLine($"Informe 10 valores para o vetor:");
int[] vetor = new int[10];

Random randomNumber = new Random();

for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = randomNumber.Next(1, 100);
}

Console.WriteLine($"Informe um valor para verificar se existe no vetor:");
int valor = int.Parse(Console.ReadLine()!);

bool existe = false;
for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] == valor)
    {
        Console.WriteLine($"O valor {valor} existe no vetor na posição {i}");
        existe = true;
    }
}

if (!existe) Console.WriteLine($"O valor {valor} não existe no vetor");

