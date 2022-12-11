
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int ans = a + b + c;
ans = Math.Max(ans, (a + b) * c);
ans = Math.Max (ans, a * (b + c));
ans = Math.Max (ans, a * b * c);

Console.WriteLine(ans);