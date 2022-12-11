


string line = Console.ReadLine();
char[] ch = line.ToCharArray();

int firstConditionCounter = 0;
int secondConditionCounter = 0;

for (int i = 0; i < ch.Length; i++)
{
    if (char.IsUpper(ch[i]))
    {
        firstConditionCounter++;
    }
    if (char.IsLower(ch[0]))
    {
        if (char.IsUpper(ch[i]))
        {
            secondConditionCounter++;
        }
    }
}

if (firstConditionCounter == ch.Length)
{
    for (int i = 0; i < ch.Length; i++)
        Console.Write(char.ToLower(ch[i]));
}

else if (secondConditionCounter == ch.Length - 1)
{
    Console.Write(char.ToUpper(ch[0]));
    for (int i = 1; i < ch.Length; i++)
    {
        Console.Write(char.ToLower(ch[i]));
    }
}

else
{
    Console.WriteLine(ch);
}






//int firstCount = 0;
//int secondCount = 0;
//int cnt = 0;


//for (int i = 0; i < ch.Length; i++)
//{
//    if (char.IsUpper(ch[i]))
//    {
//        firstCount++;
//    }

//    if (firstCount == ch.Length)
//    {
//        for (int j = 0; j < line.Length; j++)
//        {
//            Console.Write(char.ToLower(ch[j]));
//            cnt++;
//        }
//    }
//}


//if (char.IsLower(ch[0]))
//{
//    for (int i = 1; i < line.Length; i++)
//    {
//        if (char.IsUpper(ch[i]))
//        {
//            secondCount++;
//        }
//    }

//    if (secondCount == ch.Length - 1)
//    {
//        Console.Write(char.ToUpper(ch[0]));

//        for (int i = 1; i < line.Length; i++)
//        {
//            Console.Write(char.ToLower(ch[i]));
//        }
//        cnt++;
//    }

//}

//if (cnt == 0)
//    Console.WriteLine(ch);



