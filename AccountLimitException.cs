namespace ConsoleApp1
{
    internal class AccountLimitException : Exception
    {
        public AccountLimitException() : base ("Limite da conta ultrapassado\nOperação cancelada!") { }
    }
}
