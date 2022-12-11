string line = Console.ReadLine();
int count = 0;
for (int i = 0; i < line.Length; i++)
{
    if (line[i] == 'H' || line[i] == 'Q' || line[i] == '9')
    {
        Console.WriteLine("YES");
        count++;
        break;
    }
}

if (count == 0)
{
    Console.WriteLine("NO");
}