
using System.Text;

string[] line1 = Console.ReadLine().Split(' ');

int n = int.Parse(line1[0]);
int t = int.Parse(line1[1]);    

string str = Console.ReadLine();
//char[] chars = str.ToCharArray();

StringBuilder chars = new StringBuilder();
foreach (char c in str)
{
    chars.Append(c);
}


while (t-- > 0)
{
    for (int i = 0; i < n - 1; i++)
    {
        if (chars[i] == 'B' && chars[i + 1] == 'G')
        {
            (chars[i], chars[i + 1]) = (chars[i + 1], chars[i]);
            i++;
        }
    }
}

Console.WriteLine(chars);
