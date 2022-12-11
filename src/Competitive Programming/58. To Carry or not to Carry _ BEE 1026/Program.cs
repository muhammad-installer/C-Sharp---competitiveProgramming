while (true)
{
    string[] linePart = Console.ReadLine().Split(' ');

    (uint x, uint y) = (uint.Parse(linePart[0]), uint.Parse(linePart[1]));

    uint c = x ^ y;
    Console.WriteLine(c);

}



