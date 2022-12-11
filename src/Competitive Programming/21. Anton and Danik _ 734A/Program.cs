var n = Console.ReadLine();
var s = Console.ReadLine();

var a = s.Count(x => x == 'A');
var d = s.Length - a;

Console.WriteLine(a > d ? "Anton" : a < d ? "Danik" : "Friendship");



//for (int i = 0; i < n; i++)
//{
//    if (s[i] == 'A')
//    {
//        a++;
//    }
//    else
//    {
//        d++;
//    }
//}
//if (a > d)
//{
//    Console.WriteLine("Anton");
//}
//else if (d > a)
//{
//    Console.WriteLine("Danik");
//}
//else
//{
//    Console.WriteLine("Friendship");

//}

