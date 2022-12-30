string[] line1 = Console.ReadLine().Split(' ');
int n = int.Parse(line1[0]);
int h = int.Parse(line1[1]);

//var line2 = Console.ReadLine().Split(' ');
//var arr3 = line2.Select(int.Parse).ToArray();
var arr3 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



//int[] arr1 = new int[n];
//for (int i = 0; i < n; i++)
//{
//    arr1[i] = int.Parse(line2[i]);
//}



//var line2 = Console.ReadLine().Split(' ');
//int[] arr2 = Array.ConvertAll(arr2, s => int.Parse(s));
//int[] arr3 = Array.ConvertAll(line2, int.Parse);





int ans = n;
foreach (int i in arr3)
{
    if (i > h)
    {
        ans = ans + 1;
    }


}

Console.WriteLine(ans);









