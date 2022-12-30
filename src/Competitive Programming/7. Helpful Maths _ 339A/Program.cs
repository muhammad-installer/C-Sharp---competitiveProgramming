//int[] arr;
//string[] line = Console.ReadLine().Split('+');
//arr = new int[line.Length];
//for (int i = 0; i < line.Length; i++)
//{
//    arr[i] = int.Parse(line[i]);
//}
//Array.Sort(arr);
//for (int i = 0; i < arr.Length; i++)
//{
//    if (i != arr.Length - 1)
//        Console.Write($"{arr[i]}{'+'}");
//    else
//        Console.Write(arr[i]);

//}








string[] line = Console.ReadLine()!.Split('+');

Array.Sort(line);
Console.Write(line[0]); 
for(int i = 1; i < line.Length; i++)
{
    Console.Write("+");
    Console.Write(line[i]);
    
}









