namespace ConsoleApp1
{
    internal class NotSufficientAmountException : Exception
    {
        public NotSufficientAmountException() : base("Saldo insuficiente para sacar quantia.") { }
    }
}
