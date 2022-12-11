
using System.Linq;
using System.Text;

var t = int.Parse(Console.ReadLine());



while (t-- > 0)
{
    string str = Console.ReadLine();

    int len = str.Length;

    string sub1;
    string sub2;

    if (str.Length % 2 != 0)
    {
        Console.WriteLine("NO");
    }
    else
    {
        sub1 = str.Substring(0, len / 2);
        sub2 = str.Substring(len / 2);
        if (sub1 == sub2)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
