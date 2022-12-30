


///// https://onlinejudge.u-aizu.ac.jp/problems/ITP2_1_C 

/*
8
0 4
0 2
0 3
0 7
0 5
1 3
1 -2
2
*/
using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        
        int q = int.Parse(Console.ReadLine());
        LinkedList<int> list = new LinkedList<int>();
        LinkedListNode<int> cursor = list.AddLast(-1);


        while (q-- > 0)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (arr[0] == 0)
            {
                cursor = list.AddBefore(cursor, arr[1]);
                //cursor = cursor.Previous;
            }
            else if (arr[0] == 1)
            {
                if (arr[1] > 0)
                {
                    for (int i = 0; i < arr[1]; i++)
                    {
                        cursor = cursor.Next;
                    }
                }
                else
                {
                    for (int i = 0; i < -arr[1]; i++)
                    {
                        cursor = cursor.Previous;
                    }
                }
            }
            else
            {
                cursor = cursor.Next;
                list.Remove(cursor.Previous);
            }
        }
        list.RemoveLast();


        foreach (int i in list)
        {
            Console.WriteLine(i);
        }

    }

}

