

int n = int.Parse(Console.ReadLine());

var line = Console.ReadLine().Split(' ');


//bool count = true;
//foreach (var i in line)
//{
//    if (i == "1" )
//    {
//        Console.WriteLine("HARD"); 
//        count = false;
//        break;
//    }
//}
//if (count)
//{
//    Console.WriteLine("EASY");
//}




//foreach (var i in line)
//{
//    if (i == "1")
//    {
//        Console.WriteLine("HARD");
//        return;
//    }
//}
//Console.WriteLine("EASY");



//string ans = "EASY";
//foreach(string i in line)
//{
//    if (i == "1")
//    {
//        ans = "HARD";
//    }
//}
//Console.WriteLine(ans);



Console.WriteLine(line.Contains("1") ? "Hard" : "EASY");





