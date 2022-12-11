

string str = Console.ReadLine();

if (char.IsLower(str[0]))
{
    Console.Write(char.ToUpper(str[0]));
    for (int i = 1; i < str.Length; i++)
    {
        Console.Write(str[i]);
    }
}
else
{
    Console.WriteLine(str);
}
