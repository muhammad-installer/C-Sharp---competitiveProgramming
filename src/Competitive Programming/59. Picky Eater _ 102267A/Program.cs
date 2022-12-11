


//string[] line = Console.ReadLine().Split(' ');
//(int x, int y) = (int.Parse(line[0]), int.Parse(line[1]));

int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


if (arr[0] < arr[1])
{
    Console.WriteLine("0");
}
else
{
    Console.WriteLine("1");
}

