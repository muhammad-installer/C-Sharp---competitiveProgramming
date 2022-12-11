


int[] preCalculate(int[] arr1)
{
    arr1[1] = 1;
    int divisor;
    for (int i = 2; i <= 1000; i++)
    {
        divisor = 0;
        for (int j = 1; j <= Math.Sqrt(i); j++)
        {
            if (i % j == 0)
            {
                divisor += 2;
            }

        }
        double x =   Math.Sqrt(i);
        int y = (int)x;

        if (x == y)
        {
            divisor -= 1;
        }
        arr1[i] = divisor;

    }
    return arr1;
}


int t = int.Parse(Console.ReadLine());

for (int i = 1; i <= t; i++)
{
    int n = int.Parse(Console.ReadLine());

    int[] arr1 = new int[1001];

    preCalculate(arr1);

    //Array.Sort(arr1); 




}
