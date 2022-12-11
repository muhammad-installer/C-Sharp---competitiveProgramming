string line = Console.ReadLine();
string[] arr = line.Split(' ');

int n = int.Parse(arr[0]);
int k = int.Parse(arr[1]);

for (int i = 0; i < k; i++)
{
    if (n % 10 != 0)
    {
        n = n - 1;
    }
    else
    {
        n = n / 10;
    }
}

Console.WriteLine(n);
