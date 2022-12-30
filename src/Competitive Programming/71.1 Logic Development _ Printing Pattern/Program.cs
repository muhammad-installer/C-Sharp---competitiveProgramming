/*
     . . .  بِسْمِ ٱللَّٰهِ  . . .
     In The Name Of Allah   
     author    :   Muhammad
     created   :   30/12/2022 01:14:17 AM


* * * * *
 0 0 0 0
  * * *
   0 0
* * * * *
   0 0
  * * *
 0 0 0 0
* * * * *
 
-------------------------------------------------------------------------------------------------*/


var n = int.Parse(Console.ReadLine());

for (var i = 0; i < n - 1; i++)
{
    for (var k = 0; k < i; k++)
    {
        Console.Write(" ");
    }

    for (var j = i; j < n; j++)
    {
        if ((i & 1) == 1)
        {
            Console.Write("0 ");
        }
        else
        {
            Console.Write("* ");
        }
    }
    Console.WriteLine();
}

for (var i = 0; i < n; i++)
{
    Console.Write("* ");
}
Console.WriteLine();



for (var i = n - 2; i >= 0; i--)
{
    for (var k = i; k > 0; k--)
    {
        Console.Write(" ");
    }

    for (var j = i; j < n; j++)
    {

        if ((i & 1) == 1)
        {

            Console.Write("0 ");
        }
        else
        {
            Console.Write("* ");

        }

    }
    Console.WriteLine();

}
