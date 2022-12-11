
string line = Console.ReadLine();

string[] linePart = line.Split(' ');


int n = int.Parse(linePart[0]);
int t = int.Parse(linePart[1]);

if (n == 1)
{
    if (t == 10)
    {
        Console.WriteLine("-1");
    }
    else
    {
        Console.WriteLine(t);
    }
}
else if (t == 10)
{
    Console.Write('1');
    for (int j = 1; j < n; j++)
    {
        Console.Write('0');
    }
}
else
{
    for (int i = 0; i < n; i++)
    {
        Console.Write(t);
    }
}

