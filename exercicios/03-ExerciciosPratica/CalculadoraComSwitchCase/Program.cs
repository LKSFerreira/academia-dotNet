// Console.WriteLine($"Digite o primeiro número: ");
// double valor1 = double.Parse(Console.ReadLine()!);

// Console.WriteLine($"Digite a operação: ");
// char operacao = Console.ReadLine()!;

// Console.WriteLine($"Digite o segundo número: ");
// double valor2 = double.Parse(Console.ReadLine()!);

// double resultado = 0;

// switch (operacao)
// {
//     case "+":
//         resultado = valor1 + valor2;
//         break;
//     case "-":
//         resultado = valor1 - valor2;
//         break;
//     case "*":
//         resultado = valor1 * valor2;
//         break;
//     case "/":
//         resultado = valor1 / valor2;
//         break;
//     default:
//         Console.WriteLine("Operação inválida");
//         break;
// }

// Console.WriteLine($"O resultado é: {resultado}");

Console.WriteLine($"Digite um valor inteiro");
int valor = int.Parse(Console.ReadLine()!);

valor = (valor % 2 == 0) ? 1 : 2;

Console.WriteLine($"O valor é: {valor}");