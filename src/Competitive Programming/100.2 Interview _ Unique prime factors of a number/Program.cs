using System.Linq;

namespace Unique_prime_factors_of_a_number;
public class FactorCalculator
{
    public static bool isPrime(int x)
    {
        for (int i = 2; i <= Math.Sqrt(x); i++)
        {
            if (x % i == 0)
            {
                return false;
            }
        }
        return true;
    }
    public static List<int> FindFactors(int number)
    {

        var list = new List<int>();


        for (int i = 2; i <= number; i++)
        {
            if (isPrime(i) == true && number % i == 0)
            {
                list.Add(i);
            }
        }

        return list;
    }




    public static void Main(string[] args)
    {
        var number = int.Parse(Console.ReadLine()!);

        var list = FindFactors(number);

        Console.WriteLine(string.Join("  ", list));
    }

}