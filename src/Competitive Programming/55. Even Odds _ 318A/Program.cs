
string[] line = Console.ReadLine().Split();

long n = long.Parse(line[0]);
long k = long.Parse(line[1]);


long result = 0;

if (n % 2 == 0)
{
    if (k <= n / 2)
    {
        result = k * 2 - 1;
    }
    else
    {
        result = (k - (n/2) ) * 2;
    }

}
else
{
    if (k <= n / 2 + 1)
    {
        result = k * 2 - 1;
    }
    else
    {
        result = (k - (n / 2 + 1)) * 2;
    }

}

Console.WriteLine(result);