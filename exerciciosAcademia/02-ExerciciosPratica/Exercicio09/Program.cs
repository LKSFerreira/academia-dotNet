// 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
// diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:
// Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
// Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

// Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
// menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
// 150, avisá-lo que será necessário adicionar 2 unidades de insulina.

Console.WriteLine($"Digite o primeiro valor da glicemia em jejum: ");
double glicemia1 = double.Parse(Console.ReadLine()!);
if (glicemia1 < 65)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia1} e você corre risco de hipoglicemia.");
}
else if (glicemia1 > 250)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia1} e você corre risco de hiperglicemia.");
}

Console.WriteLine($"Digite o segundo valor da glicemia em jejum: ");
double glicemia2 = double.Parse(Console.ReadLine()!);
if (glicemia2 < 65)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia2} e você corre risco de hipoglicemia.");
}
else if (glicemia2 > 250)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia2} e você corre risco de hiperglicemia.");
}

Console.WriteLine($"Digite o terceiro valor da glicemia em jejum: ");
double glicemia3 = double.Parse(Console.ReadLine()!);
if (glicemia3 < 65)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia3} e você corre risco de hipoglicemia.");
}
else if (glicemia3 > 250)
{
    Console.WriteLine($"O valor da glicemia em jejum é {glicemia3} e você corre risco de hiperglicemia.");
}

double media = (glicemia1 + glicemia2 + glicemia3) / 3;
if (media < 80)
{
    Console.WriteLine($"A média dos valores da glicemia em jejum é {media} e você precisa diminuir 2 unidades de insulina.");
}
else if (media > 150)
{
    Console.WriteLine($"A média dos valores da glicemia em jejum é {media} e você precisa adicionar 2 unidades de insulina.");
}
