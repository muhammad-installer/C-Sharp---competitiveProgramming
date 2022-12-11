string line = Console.ReadLine();
string[] linePart = line.Split(' ');

int x = int.Parse(linePart[0]);
int y = int.Parse(linePart[1]);

if (x >= y)
    Console.WriteLine("1");
else
    Console.WriteLine("0");
