
int testCase = int.Parse(Console.ReadLine());

while (testCase-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    if (n == 1)
    {
        Console.WriteLine("2");
    }
    else if (n % 3 == 0)
    {
        Console.WriteLine(n / 3);
    }
    else
    {
        Console.WriteLine((n/3) + 1);
    }
}
