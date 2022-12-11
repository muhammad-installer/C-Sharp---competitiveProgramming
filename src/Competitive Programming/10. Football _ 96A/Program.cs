string line = Console.ReadLine();
int count = 1;
for (int i = 0; i < line.Length - 1; i++)
{
    //char c = line[i];
    if (line[i] == line[i + 1])
    {
        count++;
        if (count == 7)
        {
            Console.WriteLine("YES");
            break;
        }
    }
    else
    {
        count = 1;
    }
}

if (count != 7)
{
    Console.WriteLine("NO");
}
