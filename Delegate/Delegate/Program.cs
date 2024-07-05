using System.Text;


class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        ShowMoney show = Euro;
        Console.WriteLine(show(2));
        show = Dollar;
        Console.WriteLine(show(2));
    }

    public delegate string ShowMoney(int x);

    public static string Dollar(int x)
    {
        return $"{x} $" ;
    }

    public static string Euro(int x)
    {
        return $"{x} €";
    }
}