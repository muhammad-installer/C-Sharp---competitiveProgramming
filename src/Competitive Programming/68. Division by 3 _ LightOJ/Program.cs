
using System;
using System.Linq;
using System.Text; 

namespace light
{

    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());


            for (int i = 1; i <= t; i++)
            {
                StringBuilder sb = new StringBuilder();
                int count = 0;
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                //(int A, int B) = (arr[0], arr[1]);

                int A = arr[0];
                int B = arr[1];

                for (int k = A; k <= B; k++)
                {
                    long sum = 0;


                    for (int z = 1; z <= k; z++)
                    {
                        sb.Append(z);
                    }
                    for (int z = 0; z < sb.Length; z++)
                    {
                        sum = sum + (int)sb[z];
                    }

                    if (sum % 3 == 0)
                    {
                        count++;
                    }
                    sum = 0;
                    sb.Clear();
                }
                Console.WriteLine($"Case {i}: {count}");
            }

        }
    }

}