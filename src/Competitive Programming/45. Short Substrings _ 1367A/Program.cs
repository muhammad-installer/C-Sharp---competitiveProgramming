
using System.Text;

var t = int.Parse(Console.ReadLine());

//while (t-- > 0)
//{
//    var line = Console.ReadLine();

//    var subString = line.Substring(0, 2);

//    for (var i = 3; i < line.Length; i += 2)
//    {
//        subString += line[i];
//    }

//    Console.WriteLine(subString);

//}



while (t-- > 0)
{
    var s = Console.ReadLine();
    var sb = new StringBuilder();
    sb.Append(s.Substring(0, 2));

    for (int i = 3; i < s.Length; i+=2)
    {
        sb.Append(s[i]);
    }

    Console.WriteLine(sb.ToString());

}



