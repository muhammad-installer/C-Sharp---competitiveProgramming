
bool isLucky(int i)
{
    int x = i;


    while (x != 0)
    {
        int isLuck = x%10;
        if (isLuck == 4 || isLuck == 7)
        {
            x = x / 10;
            continue;
        }
        else
        {
            return false;
        }
        
    }
    return true;
}



int n = int.Parse(Console.ReadLine());

int cnt = 0;

for (int i = 1; i <= n; i++)
{
    if (isLucky(i))
    {
        if (n % i == 0)
        {
            Console.WriteLine("YES");
            cnt++;
            break;
        }
    }
}

if (cnt == 0)
{
    Console.WriteLine("NO");
}



