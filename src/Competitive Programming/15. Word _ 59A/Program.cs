string line = Console.ReadLine();
int upperCase = 0, lowerCase = 0;

for (int i = 0; i < line.Length; i++)
{
    if (line[i] >= 'A' && line[i] <= 'Z')
        upperCase++;
    else
        lowerCase++;
}

if (upperCase > lowerCase)
    Console.WriteLine(line.ToUpper());
else
    Console.WriteLine(line.ToLower());