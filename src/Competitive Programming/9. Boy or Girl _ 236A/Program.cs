//string line = Console.ReadLine();
//string ans = new string(line.Distinct().ToArray());

//if (ans.Length % 2 != 0)
//{
//    Console.WriteLine("IGNORE HIM!");
//}
//else
//{
//    Console.WriteLine("CHAT WITH HER!");
//}



string line = Console.ReadLine();

//char[] line1 = line.Distinct().ToArray();
line = new string(line.Distinct().ToArray());

if (line.Length % 2 == 0)
{
    Console.WriteLine("CHAT WITH HER!");
}
else
{
    Console.WriteLine("IGNORE HIM!");
}





