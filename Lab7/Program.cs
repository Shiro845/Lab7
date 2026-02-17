public class Program
{
    public static void Main(string[] args)
    {
        Price(1000);
    }

    public static void Price(double value)
    {
        Func<double, double> discountCalculator = null;
    
        discountCalculator += x => x * 0.95;
        discountCalculator += x => x * 0.90;
        discountCalculator += x => x - 100;

        Delegate[] discounts = discountCalculator.GetInvocationList();
    
        foreach (var discount in discounts)
        {
            Func<double, double> discountstep = (Func<double, double>)discount;

            value = discountstep(value);
        }
        Console.WriteLine(value);
    }
}
