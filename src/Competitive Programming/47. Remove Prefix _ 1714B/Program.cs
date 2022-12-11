
using static System.Console;
using System.Text;

var t = int.Parse(ReadLine());


while (t-- > 0)
{
    var n = int.Parse(ReadLine());

    var line = ReadLine().Split(" ").Select(int.Parse).ToList();
    int cnt = 0;

    var hSet = new HashSet<int>();


    for (int i = line.Count-1; i >= 0; i--)
    {
        var item = line[i];
        if (hSet.Contains(item))
        {
            cnt = line.Count - i - 1;
            break;
        }
        hSet.Add(item);  
    }
    
    WriteLine(cnt);
    
}
