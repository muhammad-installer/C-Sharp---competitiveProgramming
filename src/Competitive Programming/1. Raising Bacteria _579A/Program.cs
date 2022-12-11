/*
     . . .  بِسْمِ ٱللَّٰهِ  . . .
     In The Name Of Allah   
     author    :   Muhammad
     created   :   8/30/2022 08:53:17 PM

*/

int n = int.Parse(Console.ReadLine());

int cnt = 0;

while (n > 0)
{
    if (n % 2 == 1)
    {
        cnt++;
        n--;
    }
    else
    {
        n = n / 2;
    }
}
Console.WriteLine(cnt);