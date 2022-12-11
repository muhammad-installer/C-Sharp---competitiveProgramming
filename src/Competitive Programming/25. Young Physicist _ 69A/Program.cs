int t = int.Parse(Console.ReadLine());
int x = 0, y = 0, z = 0;

for (int i = 0; i < t; i++)
{
    string line = Console.ReadLine();
    string[] parts = line.Split(' ');
    x = x + int.Parse(parts[0]);
    y = y + int.Parse(parts[1]);
    z = z + int.Parse(parts[2]);
}

if (x == 0 && y == 0 && z == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}





