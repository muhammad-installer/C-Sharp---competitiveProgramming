
string line = Console.ReadLine();
string [] lines = line.Split(' ');

int n = int.Parse(lines[0]);
int a = int.Parse(lines[1]);
int b = int.Parse(lines[2]);


int result = Math.Min(n - a, b + 1);
Console.WriteLine(result);