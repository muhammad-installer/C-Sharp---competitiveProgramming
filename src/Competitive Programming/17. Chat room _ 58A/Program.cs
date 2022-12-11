string line = Console.ReadLine();

string given = "hello";

int j = 0, ok = 0;


for (int i = 0; i < line.Length; i++)
{
    if (line[i] == given[j])
    {
        j++;
        if (j >= 5)
        {
            Console.WriteLine("YES");
            ok = 1;
            break;
        }
    }
}

if (ok == 0)
{
    Console.WriteLine("NO");
}