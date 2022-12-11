

using static System.Console;

var t = int.Parse(ReadLine());

while (t-- > 0)
{
    var str = ReadLine();
    int count = 0;
    foreach (char c in str)
    {
        if (c == 'B')
        {
            count++;
        }
    }
    if (str.Length % 2 != 0)
    {
        WriteLine("NO");

    }
    else if (count == str.Length / 2)
    {
        WriteLine("YES");

    }
    else
    {
        WriteLine("NO");
    }
}
