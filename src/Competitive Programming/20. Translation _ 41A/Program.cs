//static string Reverse(string s)
//{
//    char[] charArray = s.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//string s = Console.ReadLine();
//string t = Console.ReadLine();

//string query = Reverse(s);

//if (t == query)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}





string line1 = Console.ReadLine();
string line2 = Console.ReadLine();

line1 = new string(line1.Reverse().ToArray());

if (line1 == line2)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}


