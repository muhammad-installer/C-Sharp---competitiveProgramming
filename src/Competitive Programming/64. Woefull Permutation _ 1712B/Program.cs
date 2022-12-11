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


using System.Text;

var q = int.Parse(Console.ReadLine());

var ansBuilder = new StringBuilder();
while (q-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    var permutation = Enumerable.Range(1, n).Reverse().ToList();
    var dif = 0;
    if (n % 2 == 1)
    {
        dif = 1;
    }
    for (var i = 0; i < n - dif; i += 2)
    {
        (permutation[i], permutation[i + 1]) = (permutation[i + 1], permutation[i]);
    }
    ansBuilder.Append($"{string.Join(" ", permutation.AsEnumerable().Reverse().ToList())}\n");
}
Console.WriteLine(ansBuilder.ToString());
