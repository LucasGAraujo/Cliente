using ClienteMaster;

class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ola");
        ClienteMaster.ClienteMaster c1 = new ClienteMaster.ClienteMaster("Lucas", "GOMES", "19191");
        Console.WriteLine(c1.Saldo);

        c1.BonusPorConta();
        Console.WriteLine(c1.Saldo);

        c1.Sacar(20);
        Console.WriteLine(c1.Saldo);
        c1.Depositar(50);

            
    }
}
