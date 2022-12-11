
/*
     . . .  بِسْمِ ٱللَّٰهِ  . . .
     In The Name Of Allah   
     author    :   Muhammad
     created   :   8/17/2022 9:37:38 AM
     more info :   https://github.com/muhammad-installer/Competitive-Programming/branches/all 
*/





using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace light_OJ
{
    class Program
    {
        long fact(long n)
        {
            //long fac = 1;
            //for (int i = 2; i <= n; i++)
            //{
            //    fac = fac * i;
            //}
            //return fac;


            if (n == 0 || n == 1) 
                return 1;
            return n * fact(n - 1);
        }


        long[] PreCalculate(long[] arr)
        {
            for (int i = 0; i <= 20; i++)
            {
                arr[i] = fact(i);
            }
            return arr;
        }

        public static void Main(string[] args)
        {
            //Console.WriteLine(DateTime.Now);


            //precaluting here 
            long[] arr = new long[30];
            Program program = new Program();
            program.PreCalculate(arr);


            int t = int.Parse(Console.ReadLine());
            for (int i = 1; i <= t; i++)
            {
                long n = long.Parse(Console.ReadLine());
                List<int> list = new List<int>();

                for (int j = 20; j >= 0; j--)
                {
                    if (arr[j] <= n)
                    {
                        n -= arr[j];
                        list.Add(j);
                    }
                }

                Console.Write($"Case {i}: ");
                if (n == 0)
                {
                    list.Reverse();
                    foreach (int z in list)
                    {

                        if (z == list[list.Count - 1])
                        {
                            Console.WriteLine($"{z}!");
                        }
                        else
                        {
                            Console.Write($"{z}!+");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"impossible");
                }



            }
        }




    }

}
