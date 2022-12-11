
//string line = ReadLine().Replace("WUB", " "); 
//string[] linePart = line.Split(" "); 

string[] linePart = Console.ReadLine().Split("WUB");
foreach (string parts in linePart) Console.Write((parts != "") ? parts + " " : "");

//foreach (string parts in linePart)
//{
//    if(parts != "")
//    {
//        Write($"{parts} ");
//    }  
//}



//// avabew hoi
//Console.WriteLine(Console.ReadLine().Replace("WUB"," "));



/* 
 
using System.Text.RegularExpressions;
string str = Console.ReadLine();
str = str.Replace("WUB", " ");
str = str.Trim();
Console.WriteLine(Regex.Replace(str, "[ ]+", " "));

*/

