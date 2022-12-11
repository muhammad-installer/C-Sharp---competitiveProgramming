
int testCase = int.Parse(Console.ReadLine());
while (testCase-- > 0)
{

    int n = int.Parse(Console.ReadLine());

    (int x, int y)[] point = new (int, int)[n+1];

    point[n] = (0, 0);

    for (int i = 0; i < n; i++)
    {
        string[] line = Console.ReadLine().Split(' ');

        //point[i].x = int.Parse(line[0]);
        //point[i].y = int.Parse(line[1]);

        point[i] = (int.Parse(line[0]), int.Parse(line[1]));
    }

    int maxX = point.Max(p => p.x);
    int minX = point.Min(p => p.x);
    int maxY = point.Max(p => p.y);
    int minY = point.Min(p => p.y);

    Console.WriteLine((maxX - minX + maxY - minY) * 2);
}
























//int testCase = Convert.ToInt32(Console.ReadLine());

//while (testCase-- > 0)
//{
//    int n = int.Parse(Console.ReadLine());

//    int maxX = 0, maxY = 0, minX = 0, minY = 0;
//    for (int i = 0; i < n; i++)
//    {
//        string[] vs = Console.ReadLine().Split(' ');

//        (int x, int y) = (int.Parse(vs[0]), int.Parse(vs[1]));


//        maxX = Math.Max(maxX, x);
//        minX = Math.Min(minX, x);

//        maxY = Math.Max(maxY, y);
//        minY = Math.Min(minY, y);



//    }
//    Console.WriteLine(((maxX - minX) + (maxY - minY)) * 2);
//    //Console.WriteLine((maxX + Math.Abs(minX) + Math.Abs(minY) + maxY) * 2);

//}



///---------------------------------------------------------------------------------------------------------------
//int t = int.Parse(Console.ReadLine());

//while (t-- > 0)
//{
//    int n = int.Parse(Console.ReadLine());
//    int c1 = 0, c2 = 0, c3 = 0, c4 = 0;

//    for (int i = 0; i < n; i++)
//    {

//        string[] arr = Console.ReadLine().Split(' ');
//        //int x = int.Parse(arr[0]);
//        //int y = int.Parse(arr[1]);

//        (int x, int y) = (int.Parse(arr[0]), int.Parse(arr[1]));




//        if (x > 0 && x > c1)  // plus
//        {
//            c1 = x;

//        }
//        else if (x < 0 && x < c2) // minus
//        {
//            c2 = x;


//        }
//        else if (y > 0 && y > c3)  // plus
//        {
//            c3 = y;

//        }
//        else // y minus
//        {
//            if (y < c4)
//            {
//                c4 = y;
//            }
//        }
//    }

//    int sum = Math.Abs(c1) + Math.Abs(c2) + Math.Abs(c3) + Math.Abs(c4);

//    Console.WriteLine(sum * 2);

//}




///using tuple and linq --------------------------------------------------------------------------------

//int t = int.Parse(Console.ReadLine());

//for (int i = 0; i < t; i++)
//{
//    int n = int.Parse(Console.ReadLine());
//    (int x, int y)[] points = new (int, int)[n+1];
//    points[n] = (0, 0);
//    for (int j = 0; j < n; j++)
//    {
//        var toks = Console.ReadLine().Split();

//        //points[j].x = int.Parse(toks[0]);
//        //points[j].y = int.Parse(toks[1]);

//        (points[j].x, points[j].y) = (int.Parse(toks[0]), int.Parse(toks[1]));


//    }
//    int maxx = points.Max(p => p.x);
//    int minx = points.Min(p => p.x);
//    int maxy = points.Max(p => p.y);
//    int miny = points.Min(p => p.y);

//    Console.WriteLine(((maxx - minx) + (maxy - miny)) * 2);
//}