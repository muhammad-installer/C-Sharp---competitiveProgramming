/// https://onlinejudge.u-aizu.ac.jp/problems/ITP2_7_A
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var set = new HashSet<int>();
        StringBuilder sb = new StringBuilder();


        int q = int.Parse(Console.ReadLine());
        while (q-- > 0)
        {
            var line = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            (int command, int value) = (line[0], line[1]); 


            if (command == 0)
            {
                set.Add(value);
                sb.Append(set.Count + "\n");
            }
            else
            {
                int count = 0;
                if (set.Contains(value))
                {
                    count = 1;
                }

                sb.Append(count + "\n");
            }
        }
        Console.Write(sb.ToString());
    }
}




