string line = Console.ReadLine().ToLower();

for (int i = 0; i < line.Length; i++)
{
    if (line[i] == 'a' || line[i] == 'e' || line[i] == 'i' || line[i] == 'o' || line[i] == 'u' || line[i] == 'y')
    {

    }
    else
    {
        Console.Write($"{'.'}{line[i]}");
    }
}