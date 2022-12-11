string N;
N = Console.ReadLine();
int n = int.Parse(N);

for (int i = 0; i < n; i++)
{
    string str;
    str = Console.ReadLine();
    int strlen = str.Length;
    if (strlen <= 10)
    {
        Console.WriteLine(str);
    }
    else
    {
        Console.WriteLine($"{str[0]}{strlen - 2}{str[strlen - 1]}");
    }

}