int[] vetor = new int[3];

for (int i = 0; i < vetor.length; i++)
{
    Console.WriteLine($"Informe um valor para a posição {i}:");
    vetor[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < vetor.Length; i++)
{
    Console.WriteLine($"O vetor possui o valor {vetor[i]} na posição {i}");
    Console.WriteLine($"vetor[{i}] = {vetor[i]}");
}