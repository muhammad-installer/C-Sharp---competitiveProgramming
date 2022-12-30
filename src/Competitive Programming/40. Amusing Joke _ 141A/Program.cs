
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




string guestName = Console.ReadLine();
string hostName = Console.ReadLine();  
string pileOfLetters = Console.ReadLine();

string str = guestName + hostName;

string[] line1 = str.Split(' ');
string[] line2 = pileOfLetters.Split(' ');

Array.Sort(line1);
Array.Sort(line2);

Console.WriteLine(line2);
Console.WriteLine(line1);