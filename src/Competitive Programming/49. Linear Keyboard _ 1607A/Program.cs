using static System.Console;

var t = int.Parse(ReadLine());

while (t-- > 0)
{
    string line1 = ReadLine();

    string line2 = ReadLine();
    int ans = 0;
    for (int i = 0; i<line2.Length-1; i++)
    {
        int x = line1.IndexOf(line2[i]);
        int y = line1.IndexOf(line2[i+1]);

        ans = ans + Math.Abs(x - y);

    }

    WriteLine(ans);



}






