namespace ConsoleApp1
{
    internal class AccountActivityException : Exception
    {
        public AccountActivityException() : base("Impossivel fazer operação\nConta Inativa") {}
    }
}
