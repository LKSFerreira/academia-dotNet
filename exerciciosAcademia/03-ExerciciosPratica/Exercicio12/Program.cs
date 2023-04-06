// 12 - Elabore um programa em VS que leia as variáveis "codigo" e "numeroHoras", respectivamente código e 
// número de horas trabalhadas de um operário. Na sequência, calcule o salário sabendo-se que ele ganha 
// R$ 10,00 por hora. Quando o número de horas exceder a 50 calcule o excesso de pagamento 
// armazenando-o na variável "extra", caso contrário zerar tal variável. A hora excedente de trabalho vale R$ 20,00. 
// No final do processamento, exibir o salário total e o salário excedente do operário.

Console.WriteLine($"Digite o código do funcionário");
int codigo = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Digite o número de horas trabalhadas");
int numeroHoras = int.Parse(Console.ReadLine()!);

double valorPorHora = 10;
double salarioExtra = 0;
int horasExtra = numeroHoras <= 50 ? numeroHoras : numeroHoras - 50;

double salario = numeroHoras <= 50 ? numeroHoras * valorPorHora : salarioExtra = (horasExtra * 20); salario = ((numeroHoras - horasExtra) * valorPorHora) + salarioExtra;


Console.WriteLine($"O salário total é: {salario}");
Console.WriteLine($"O salário excedente é: {salarioExtra}");