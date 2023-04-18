// 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
// medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse 
// valor para a unidade de saída selecionada.

string unidadesMedida = "1 - metros, 2 - centímetros, 3 - polegadas ou 4 - pés";
Console.WriteLine($"Digite a unidade de medida de entrada ({unidadesMedida})");
int unidadeMedidaEntrada = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite a unidade de medida de saída ({unidadesMedida})");
int unidadeMedidaSaida = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o valor de entrada");
double valorEntrada = double.Parse(Console.ReadLine()!);

double valorSaida = 0;

switch (unidadeMedidaEntrada)
{
    case 1:
        switch (unidadeMedidaSaida)
        {
            case 1:
                valorSaida = valorEntrada;
                break;
            case 2:
                valorSaida = valorEntrada * 100;
                break;
            case 3:
                valorSaida = valorEntrada * 39.37;
                break;
            case 4:
                valorSaida = valorEntrada * 3.281;
                break;
            default:
                Console.WriteLine($"Unidade de medida de saída inválida");
                break;
        }
        break;
    case 2:
        switch (unidadeMedidaSaida)
        {
            case 1:
                valorSaida = valorEntrada / 100;
                break;
            case 2:
                valorSaida = valorEntrada;
                break;
            case 3:
                valorSaida = valorEntrada * 0.3937;
                break;
            case 4:
                valorSaida = valorEntrada * 0.03281;
                break;
            default:
                Console.WriteLine($"Unidade de medida de saída inválida");
                break;
        }
        break;
    case 3:
        switch (unidadeMedidaSaida)
        {
            case 1:
                valorSaida = valorEntrada / 39.37;
                break;
            case 2:
                valorSaida = valorEntrada / 0.3937;
                break;
            case 3:
                valorSaida = valorEntrada;
                break;
            case 4:
                valorSaida = valorEntrada * 0.08333;
                break;
            default:
                Console.WriteLine($"Unidade de medida de saída inválida");
                break;
        }
        break;
    case 4:
        switch (unidadeMedidaSaida)
        {
            case 1:
                valorSaida = valorEntrada / 3.281;
                break;
            case 2:
                valorSaida = valorEntrada / 0.03281;
                break;
            case 3:
                valorSaida = valorEntrada / 0.08333;
                break;
            case 4:
                valorSaida = valorEntrada;
                break;
            default:
                Console.WriteLine($"Unidade de medida de saída inválida");
                break;
        }
        break;
    default:
        Console.WriteLine($"Unidade de medida de entrada inválida");
        break;
}

Console.WriteLine($"O valor de saída é: {valorSaida}");