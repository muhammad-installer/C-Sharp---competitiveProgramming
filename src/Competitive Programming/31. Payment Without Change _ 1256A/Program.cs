

int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string[] vs = Console.ReadLine().Split(' ');
    ulong a = ulong.Parse(vs[0]);
    ulong b = ulong.Parse(vs[1]);
    ulong n = ulong.Parse(vs[2]);
    ulong S = ulong.Parse(vs[3]);


    ulong vagFol = S / n;
    ulong sum ;
    if (vagFol <= a)
    {
        sum = vagFol * n;
    }
    else
    {
        sum = n * a;
    }
    

    if (sum + b >= S)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }

}
