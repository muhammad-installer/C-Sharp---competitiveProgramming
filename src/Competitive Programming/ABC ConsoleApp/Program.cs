
var guestName = Console.ReadLine();
var hostName = Console.ReadLine();
var pileOfLetters = Console.ReadLine();

var str = guestName + hostName;
str = String.Concat(str.OrderBy(f => f));
pileOfLetters = String.Concat(pileOfLetters.OrderBy(f => f));

if (string.Compare(str, pileOfLetters) == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

Console.WriteLine();









//using System.Text;

//string a, b, c, s;
//a = Console.ReadLine();
//b = Console.ReadLine();
//c = Console.ReadLine(); 

//s = a + b;



////Here, string are : s   and   c 
////char[] charArrayS = s.ToCharArray(); 
////Array.Sort(charArrayS);
////s = charArrayS.ToString();

////char[] charArrayC = c.ToCharArray();
////Array.Sort(charArrayC);
////c = charArrayC.ToString();



//s = String.Concat(s.OrderBy(f => f));
//c = String.Concat(c.OrderBy(f => f));



//if (string.Compare(s, c) == 0)
//{
//    Console.WriteLine("YES");

//}
//else
//{
//    Console.WriteLine("NO");
//}



