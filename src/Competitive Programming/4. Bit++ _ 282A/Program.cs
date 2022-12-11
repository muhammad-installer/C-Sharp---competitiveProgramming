string N = Console.ReadLine();
int n;
n = int.Parse(N);
int x = 0;
while (n > 0)
{

    string str = Console.ReadLine();
    if (str == "x++" || str == "++x" || str == "X++" || str == "++X")
    {
        x++;
    }
    else
    {
        x--;
    }
    n--;
}
Console.WriteLine(x);