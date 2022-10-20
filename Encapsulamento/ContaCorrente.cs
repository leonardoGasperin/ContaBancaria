namespace Encapsulamento
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal Saldo
        {
            get { return this.saldo; }
        }

        public ContaCorrente(int numeroConta, decimal saldo, Client client)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
            this.client = client;
        }

        public void Sacar(decimal valor)
        {
            if(this.saldo < valor){
                throw new Exception("Saldo insuficiente.");
            }

            this.saldo -= valor;
        }
    }
}