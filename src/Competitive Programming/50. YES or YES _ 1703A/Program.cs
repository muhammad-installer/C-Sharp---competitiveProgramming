

using System.Text;
using static System.Console;

var t = int.Parse(ReadLine());  

while (t-- > 0)
{
    string str = Console.ReadLine();
    var sb = new StringBuilder();

    sb.Append(str.ToLower());


    if (sb.ToString() == "yes")
    {
        WriteLine("YES");

    }
    else
    {
        WriteLine("NO");

    }

}
