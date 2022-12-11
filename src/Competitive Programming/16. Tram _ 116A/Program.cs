int result = 0;

int line = int.Parse(Console.ReadLine());

int[] arrFinal = new int[line];

for (int i = 0; i < line; i++)
{
    string input = Console.ReadLine();
    string[] s = input.Split(' ');
    int[] arr = new int[2];
    arr[0] = int.Parse(s[0]);
    arr[1] = int.Parse(s[1]);

    result = (result - arr[0]) + arr[1];

    arrFinal[i] = result;

}



Math.Max(23,3);

int maxValue = arrFinal.Max();
Console.WriteLine(maxValue);


