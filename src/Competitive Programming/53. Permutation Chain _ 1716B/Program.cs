

int testCase = int.Parse(Console.ReadLine());

while (testCase-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine(n);
    for (int i = n; i >= 1; i--)
    {
        Console.Write($"{i} ");
    }
    Console.WriteLine();


}
