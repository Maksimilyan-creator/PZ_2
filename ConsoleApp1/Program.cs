// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y");
double y = Convert.ToDouble(Console.ReadLine());
Plane plane = new(x, y);
Console.WriteLine(plane.distance());
sealed class Plane
{
    private readonly double first;
    private readonly double second;
  
    public Plane(double a, double c)
    {
        first = a;
        second = c;
    }
    public double First
    {
        get => first;
    }
    public double Second
    {
        get => second;
    }
    public double distance()
        => second - first;
}*/

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Account account = new Account
        {
            ФамилияВладельца = "Тинькоф",
            НомерСчета = "богач777",
            ПроцентНачисления = 15,
            СуммаРубли = 700000 
        };

        СменаВладельца(account, "Ламаев");
        СнятьНекоторуюСуммуСчета(account, 1000);
        ПоложитьНаСчет(account, 7700);
        НачислитьПроцентыЗаМесяц(account);
        ПеревестиЕвро(account);
        ПеревестиДоллары(account);
        СуммаПрописью(account);

    }

    static void СменаВладельца(Account account, string новыйВладелец)
    {
        account.ФамилияВладельца = новыйВладелец;
    }

    static void СнятьНекоторуюСуммуСчета(Account account, int сумма)
    {
        account.СуммаРубли = сумма;
    }

    static void ПоложитьНаСчет(Account account, int сумма)
    {
        account.СуммаРубли = сумма;
    }

    static void НачислитьПроцентыЗаМесяц(Account account)
    {
        account.СуммаРубли = account.СуммаРубли * (1 + account.ПроцентНачисления);
    }

    static void ПеревестиЕвро(Account account)
    {
        Console.WriteLine("Счет в евро = " + (account.СуммаРубли / 150).ToString());
    }

    static void ПеревестиДоллары(Account account)
    {
        Console.WriteLine("Счет в долларах = " + (account.СуммаРубли / 100).ToString());
    }

    static void СуммаПрописью(Account account)
    {
        string result = "";
        decimal one = decimal.Truncate(account.СуммаРубли);
        if (account.СуммаРубли < 0)
        {
            result += "минус";
            one = decimal.Negate(one);
        }
        int i = 0;
        string[] разрядность = new string[]
        {
            "","тыс","мил"
        };
        while (one > 0)
        {
            result = Get(Convert.ToInt32(one % 1000)) + "" + разрядность[i] + result;
            i++;
            one = decimal.Truncate(one / 1000);
        }
        if (!string.IsNullOrEmpty(result))

            result += "руб";

        if ((one = decimal.Truncate(account.СуммаРубли * 100) % 100) > 0)

            result += Get(Convert.ToInt32(one)) + "коп";

        Console.WriteLine("на счету " + (string.IsNullOrEmpty(result) ? "ноль" : result));

        static string Get(int val)
        {
            string[] сотни = new string[] { "", "сто", "двести", "триста", "четьіреста", "пятсот", "шесот", "семсот", "восемсот", "девятсот" };
            string[] десятки = new string[] { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестдесят", "семдесят", "восемдесят", "девяносто" };
            string[] единицы = new string[] { "", "один", "два", "три", "четьіре", "пять", "шесть", "сем", "восем", "девять",
                "десять", "одинадцать", "двенадцать", "тринадцать", "четьірнадцать", "шеснадцать", "семнадцать", "восемнадцать", "девятьнадцать"};
            return (сотни[val / 100] + " " + десятки[val / 10 % 10] + " " + единицы[val % 10 + (val / 10 % 10 == 1 ? 10 : 0)]).Replace("  ", " ");
        }
    } 
}





