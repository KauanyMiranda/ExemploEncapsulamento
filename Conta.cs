using static System.Console;
using static System.Convert;
public class Conta
{
    private double _saldo;

    public void SetSaldo(double s)
    {
        if (s >= 0 )
        {
            _saldo = s;
        }
        else
        {
            WriteLine("Saldo Inválido");
        }
    }
}
