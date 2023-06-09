// 3 - Crie uma classe ContaCorrente que obedeça à descrição abaixo: A classe possui o atributo saldo do tipo 
// double e os métodos definirSaldoInicial, depositar e sacar. O método definirSaldoInicial deve atribuir o
// valor passado por parâmetro ao atribuito saldo O método depositar, deve adicionar o valor passado por
// parâmetro ao atributo saldo O método sacar deve reduzir o valor passado por parâmetro do saldo já 
// existente Necessário verificar a condição de o valor do saldo ser insuficiente para o saque que se deseja
// fazer. O valor de retorno deve ser true (verdadeiro) quando for possível realizar o saque e false (falso)
// quando não for possível

class ContaCorrente
{
    private double saldo;

    public ContaCorrente(double saldo)
    {
        this.saldo = saldo;
    }

    public void Depositar(double valor)
    {
        saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (saldo >= valor)
        {
            saldo -= valor;
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return $"Saldo: {saldo}";
    }
}