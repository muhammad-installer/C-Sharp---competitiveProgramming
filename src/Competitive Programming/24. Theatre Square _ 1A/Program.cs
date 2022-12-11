string line = Console.ReadLine();
string[] lineParts = line.Split(' ');
decimal n = int.Parse(lineParts[0]);
decimal m = int.Parse(lineParts[1]);
decimal a = int.Parse(lineParts[2]); 
decimal result = Math.Ceiling(n/a) * Math.Ceiling(m/a);

Console.WriteLine(result);

