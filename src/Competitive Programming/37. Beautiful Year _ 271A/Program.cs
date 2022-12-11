
int y = int.Parse(Console.ReadLine());

while (true)
{
    y = y + 1;
    string str = Convert.ToString(y);

    HashSet<char> digit = new HashSet<char>();

    foreach (char c in str)
    {
        digit.Add(c);
    }

    if (digit.Count == str.Length)
    {
        Console.WriteLine(y);
        break;
    }

}





