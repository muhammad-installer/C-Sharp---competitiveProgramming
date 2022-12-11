
int n = int.Parse(Console.ReadLine());

var ints = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


for (int i = 1; i <= ints.Length; i++)
{
    for (int j = 0; j < ints.Length; j++)
    {
        if (ints[j] == i)
        {
            Console.Write($"{j + 1} ");
            //Console.Write((j + 1) + " ");
           
           
        }
    }
}
