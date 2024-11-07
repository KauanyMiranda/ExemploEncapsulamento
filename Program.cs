using static System.Convert;
using static System.Console;

public class Program
{
    static void Main(string[] args)
    {
        Conta c = new Conta();

        Write("Digite o saldo: ");
        double saldo = ToDouble(ReadLine());
        c.SetSaldo(saldo);
    } 
}