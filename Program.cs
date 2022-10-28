using ConsoleApp1;

var contaCorrente = new ContaCorrente()
{
    Numero = 0001,
    IsActive = true,
    Limite = 1000,
    Saldo = 5000
};

var contaPoupanca = new ContaPoupanca()
{
    Numero = 0002,
    IsActive = true,
    Limite = 100,
    Saldo = 10
};

var contaSalario = new ContaSalario()
{
    Numero = 0003,
    IsActive = false,
    Limite = 100000,
    Saldo = 55000
};

Console.WriteLine("\t\tSeja bem vindo(a) ao Banco BZ o Banco do Zequinha!" +
              $"escolha um das opções:\n0-{Operacoes.mostrarSaldo}\n1-{Operacoes.sacar}\n2-{Operacoes.depositar}");
var opr = Console.ReadLine();

try
{
    switch (int.Parse(opr))
    {
        case (int)Operacoes.mostrarSaldo:
            contaCorrente.MostrarSaldo();
            Console.WriteLine($"Saldo: {contaCorrente.Saldo}");
            break;
        case (int)Operacoes.sacar:
            contaCorrente.Sacar(1001);
            Console.WriteLine("Valor sacado com sucesso");
            break;
        case (int)Operacoes.depositar:
            contaCorrente.Depositar(500);
            break;
        default:
            break;
    }
}
catch(AccountActivityException e)
{
    Console.WriteLine(e.Message);
}
catch (NotSufficientAmountException e)
{
    Console.WriteLine(e.Message);
}
catch (AccountLimitException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine($"nome da Exception: {e.GetType().Name}\n" +
                      $"Tipo: {e.GetType()}\n" +
                      $"Menssage: {e.Message}\n");
}
