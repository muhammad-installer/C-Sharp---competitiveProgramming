
int n = int.Parse(Console.ReadLine());
int count = 0;

for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    string[] parts = line.Split(' ');
    int[] arr = Array.ConvertAll(parts, int.Parse);

    if (arr[0] + arr[1] + arr[2] >= 2)
    {
        count++;
    }
}
Console.WriteLine(count);
