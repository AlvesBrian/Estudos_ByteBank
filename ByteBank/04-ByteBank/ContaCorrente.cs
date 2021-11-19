public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100.0;

    public bool Sacar(double valor)
    {
        if (saldo < valor)
        {
            return false;
        }

        saldo -= valor;

        return true;
    }

    public void Depositar(double valor)
    {
        if (valor > 0.0)
        {
            saldo += valor;
        }
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (saldo < valor)
        {
            return false;
        }

        saldo -= valor;

        contaDestino.Depositar(valor);

        return true;
    }
}