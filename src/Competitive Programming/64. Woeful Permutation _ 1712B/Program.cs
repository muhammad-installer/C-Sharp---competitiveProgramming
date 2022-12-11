
int t = int.Parse(Console.ReadLine());

while (t-- > 0)
{
    int n = int.Parse(Console.ReadLine());

    if ((n & 1) == 1)
    {
        Console.Write(1 + " ");
        for (int i = 3; i <= n; i += 2)
        {
            Console.Write(i + " " + (i - 1) + " ");
        }
        Console.WriteLine();
    }
    else
    {
        for (int i = 2; i <= n; i += 2)
        {
            Console.Write(i + " " + (i - 1) + " ");
        }
        Console.WriteLine();
    }




}
