/// https://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ITP2_1_D
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {

        int[] nq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = nq[0];

        //List<int>[] _2dList = new List<int>[n];    
        List<List<int>> _2dList = new List<List<int>>(); 
        StringBuilder sb = new StringBuilder();

        

        for (int i = 0; i < nq[0]; i++)
        {
            //_2dList[i] = new List<int>();     
            _2dList.Add(new List<int>());
               
        }


        while (nq[1]-- > 0)
        {
            
            int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int command = query[0]; 
            int _2dListIndex = query[1]; 

            
            if (command == 0)
            {
                _2dList[_2dListIndex].Add(query[2]); 
            }
            else if (command == 1)
            {
                sb.Append(string.Join(" ", _2dList[_2dListIndex]) + "\n");
            }
            else
            {
                _2dList[_2dListIndex].Clear();
            }


        }
        Console.Write(sb.ToString());
    }
}