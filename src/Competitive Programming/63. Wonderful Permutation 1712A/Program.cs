
int t = int.Parse(Console.ReadLine()!);

while (t-- > 0)
{
    int[] nk = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();

    int count = 0;

    List<int> list = Console.ReadLine()!.Split().Select(int.Parse).ToList();

    //HashSet<int> set = new HashSet<int>();
    //for (int i = 0; i < nk[1]; i++)
    //{
    //    set.Add(list[i]);
    //}


    for (int i = 0; i < nk[1]; i++) if (list[i] > nk[1]) count++;
    //{

    //    if (!set.Contains(i + 1))
    //    {
    //        count++;
    //    }

    //}
   
    Console.WriteLine(count);


}

