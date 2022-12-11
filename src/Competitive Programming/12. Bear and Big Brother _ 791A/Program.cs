string line = Console.ReadLine();
string[] arr = line.Split(' ');

int weightOfLimak = int.Parse(arr[0]);
int weightOfBob = int.Parse(arr[1]);
int count = 0;


while (weightOfLimak <= weightOfBob)
{
    weightOfLimak = weightOfLimak * 3;
    weightOfBob = weightOfBob * 2;
    count++;
}
Console.WriteLine(count);