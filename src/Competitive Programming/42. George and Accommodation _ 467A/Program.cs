
int n = int.Parse(Console.ReadLine());
int count = 0;
while (n-- > 0)
{
    //string line = Console.ReadLine();
    //string[] part = line.Split(' ');
    //int p = int.Parse(part[0]);
    //int q = int.Parse(part[1]);


    //var ints = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    //var ints = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
    var ints = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
    if (ints[1] - ints[0] > 1)
    {
        count++; 
    }


}

Console.WriteLine(count);
