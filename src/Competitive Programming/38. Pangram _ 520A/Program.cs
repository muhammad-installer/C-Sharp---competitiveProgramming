
int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();
HashSet<char> vs = new HashSet<char>();


foreach (char c in str)
{
    vs.Add(char.ToUpper(c));
}


if (vs.Count == 26)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");

}


