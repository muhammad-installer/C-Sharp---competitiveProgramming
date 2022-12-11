string line = Console.ReadLine();
int k, n, w;
string[] arr = line.Split(' ');
k = int.Parse(arr[0]);
n = int.Parse(arr[1]);
w = int.Parse(arr[2]);
int cost = 0;

for (int i = 1; i <= w; i++)
{
    cost = cost + (i * k);
}


if (cost > n)
{
    Console.WriteLine(cost - n);
}
else
{
    Console.WriteLine(0);
}