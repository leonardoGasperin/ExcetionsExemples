namespace ConsoleApp1
{
    internal class ContaBancaria
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public int Limite { get; set; }
        public bool IsActive { get; set; }

        public void Sacar(int valor)
        {
            if(!IsActive) { throw new AccountActivityException(); }
            if(valor > Limite) { throw new AccountLimitException(); }
            if (valor > Saldo) { throw new NotSufficientAmountException(); }
            
            Saldo -= valor;
        }
        public void Depositar(int valor)
        {
            if (!IsActive) { throw new AccountActivityException(); }
            Saldo += valor;
        }
        public void MostrarSaldo()
        {
            if (!IsActive) { throw new AccountActivityException(); }
        }
    }
}
