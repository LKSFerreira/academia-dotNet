// 8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor. Exemplo:
// a.	lê:          	|5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
// b.	escreve: 	|3|5|6|7|9|10|14|. . .

Console.WriteLine($"Informe 30 valores para o vetor:");
double[] vetor = new double[5];
for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = double.Parse(Console.ReadLine()!);
}

for (int i = 0; i < vetor.Length; i++)
{
    if (vetor[i] < 0)
    {
        Console.Write($"{i}|");
    }
}
