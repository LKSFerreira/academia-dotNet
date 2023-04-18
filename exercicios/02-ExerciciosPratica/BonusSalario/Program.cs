Console.WriteLine($"Digite o salário do funcionário: ");
decimal salario = decimal.Parse(Console.ReadLine()!);

decimal bonus05Porcento = 0.05m;
decimal bonus08Porcento = 0.08m;
decimal bonus10Porcento = 0.10m;

decimal salarioComBonus = 0;
decimal valorBonus = 0;

if (salario <= 900)
{
    valorBonus = salario * bonus05Porcento;
}
else if (salario > 900 && salario < 1400)
{
    valorBonus = salario * bonus08Porcento;
}
else
{
    valorBonus = salario * bonus10Porcento;
}

salarioComBonus = salario + valorBonus;

Console.WriteLine($"===================================");
Console.WriteLine($"Salário atual do funcionário: {salario.ToString("C")}");
Console.WriteLine($"Valor do bônus: {valorBonus.ToString("C")}");
Console.WriteLine($"Salário com bônus: {salarioComBonus.ToString("C")}");
