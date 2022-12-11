
string[] line1 = Console.ReadLine().Split(' ');
int[] arr1 = Array.ConvertAll(line1, int.Parse);


string[] line2 = Console.ReadLine().Split(' ');
int[] arr2 = Array.ConvertAll(line2, int.Parse);




int pos = 0;
for (int i = 0; i < arr2.Length; i++)
{
    if (arr2[i] >= arr2[arr1[1]-1]  && arr2[i] > 0)
    {
        pos++;
    }
}

Console.WriteLine(pos);


