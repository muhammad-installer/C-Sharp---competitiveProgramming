//int t = int.Parse(Console.ReadLine());

//while (t-- > 0)
//{
//    int n = int.Parse(Console.ReadLine());

//    if ((n & 1) == 1)
//    {
//        Console.Write(1 + " ");
//        for (int i = 3; i <= n; i += 2)
//        {
//            Console.Write(i + " " + (i - 1) + " ");
//        }
//        Console.WriteLine();
//    }
//    else
//    {
//        for (int i = 2; i <= n; i += 2)
//        {
//            Console.Write(i + " " + (i - 1) + " ");
//        }
//        Console.WriteLine();
//    }




//}


//-------------------------------------------------------------------------
//using System.Text;

//var q = int.Parse(Console.ReadLine());

//var ansBuilder = new StringBuilder();
//while (q-- > 0)
//{
//    int n = int.Parse(Console.ReadLine());
//    var permutation = Enumerable.Range(1, n).ToList();
//    var dif = 0;

//    int i = 0;

//    if (n % 2 == 1)
//    {
//        i = 1;
//    }
//    for (i = i; i < n; i += 2)
//    {
//        (permutation[i], permutation[i + 1]) = (permutation[i + 1], permutation[i]);
//    }
//    ansBuilder.Append($"{string.Join(" ", permutation.AsEnumerable().ToList())}\n");
//}
//Console.WriteLine(ansBuilder.ToString());


using System.Text;

var t = int.Parse(Console.ReadLine());
var sb = new StringBuilder();
while (t-- > 0)
{
    var n = int.Parse(Console.ReadLine());

    var list = Enumerable.Range(1, n).Reverse().ToList();
    int d = 0;
    if ((n & 1) == 1)
    {
        d = 1;
    }

    for (int i = 0; i < n - d; i += 2)
    {
        (list[i], list[i + 1]) = (list[i + 1], list[i]);
    }
    sb.Append($"{string.Join(" ", list.AsEnumerable().Reverse().ToList())}\n");

}
Console.WriteLine(sb);
