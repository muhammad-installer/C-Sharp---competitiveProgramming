
int testCase = int.Parse(Console.ReadLine());

while (testCase-- > 0)
{
    string line1 = Console.ReadLine();
    
    char ch = char.Parse(Console.ReadLine());
    //char ch = Convert.ToChar(Console.ReadLine());
    //char ch = Console.ReadLine()[0];
    //char ch = Console.ReadLine().First();


    bool result = false;

    for (int i = 0; i < line1.Length; i++)
    {
        if (line1[i] == ch && i%2 == 0)
        {
            result = true;
            break;
        }
    }


    if (result)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }


}
