// 10.	Escreva um algoritmo que leia um vetor inteiro de 20 posições. Crie um segundo vetor, substituindo os valores nulos por 2. Mostre os vetores lidos e o vetor resultado.

Console.WriteLine($"Informe 20 valores para o vetor 1:");
int[] vetorCom20Posicoes = new int[5];
for (int i = 0; i < vetorCom20Posicoes.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    string valor = Console.ReadLine()!;
    if (int.TryParse(valor, out int valorConvertido))
    {
        vetorCom20Posicoes[i] = valorConvertido;
    }
    else
    {
        vetorCom20Posicoes[i] = 0;
    }
}

int[] vetorCom20Posicoes2 = new int[5];
for (int i = 0; i < vetorCom20Posicoes2.Length; i++)
{
    if (vetorCom20Posicoes[i] == 0)
    {
        vetorCom20Posicoes2[i] = 2;
    }
    else
    {
        vetorCom20Posicoes2[i] = vetorCom20Posicoes[i];
    }
}

Console.WriteLine($"Vetor 1:");
for (int i = 0; i < vetorCom20Posicoes.Length; i++)
{
    Console.Write($"Posição {i}: {vetorCom20Posicoes[i]}| ");
}
Console.WriteLine($"");
Console.WriteLine($"Vetor 2:");
for (int i = 0; i < vetorCom20Posicoes2.Length; i++)
{
    Console.Write($"Posição {i}: {vetorCom20Posicoes2[i]}| ");
}
