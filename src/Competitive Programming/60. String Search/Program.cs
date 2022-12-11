using System;

class Program
{
    static void Main(string[] args)
    {
        ///https://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_14_B

        string text = Console.ReadLine();

        string p = Console.ReadLine();
        for (int i = 0; i < text.Length - (p.Length - 1); i++)
        {

            string str = text.Substring(i, p.Length);
            if (p == str)
            {
                Console.WriteLine(i);
            }
        }



    }
}


/////https://judge.u-aizu.ac.jp/onlinejudge/description.jsp?id=ALDS1_14_B
//using System;
//using System.Text;
//class Program
//{
//    static void Main(string[] args)
//    {
//        string text = Console.ReadLine();

//        string p = Console.ReadLine();

//        StringBuilder t = new StringBuilder();

//        for (int i = 0; i < text.Length - (p.Length - 1); i++)
//        {

//            string str = text.Substring(i, p.Length);
//            if (p == str)
//            {
//                t.AppendLine(i.ToString());

//            }
//        }
//        Console.WriteLine(t);

//    }
//}

