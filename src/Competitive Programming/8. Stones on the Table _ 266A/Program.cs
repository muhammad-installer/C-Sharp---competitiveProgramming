string N = Console.ReadLine();
int n = int.Parse(N);

string line = Console.ReadLine();
int count = 0;
char c = line[0];


for (int i = 1; i < line.Length; i++)
{
    if (line[i] == c)
    {
        count++;
    }
    else
    {
        c = line[i];
    }
}

Console.WriteLine(count);