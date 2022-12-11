/*
     . . .  بِسْمِ ٱللَّٰهِ  . . .
     In The Name Of Allah   
     author    :   Muhammad
     created   :   8/30/2022 08:53:17 PM

*/


int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] vs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int n = vs[0];
    int m = vs[1];
    long sum = m + n;

    if (sum % 2 == 0)
    {
        Console.WriteLine("Tonya");
    }
    else
    {
        Console.WriteLine("Burenka");
    }
}

