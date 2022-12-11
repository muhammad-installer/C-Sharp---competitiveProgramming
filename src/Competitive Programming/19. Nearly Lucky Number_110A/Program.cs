string num = Console.ReadLine();
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i] == '4' || num[i] == '7')
    {
        count++;
    }
}

if (count == 4 || count == 7)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");