

int n = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < n; i++)
{
    
    string str = Console.ReadLine(); 
    switch (str)
    {
        case "Tetrahedron":
            count = count + 4;
            break;

        case "Cube":
            count = count + 6;
            break;

        case "Octahedron":
            count = count + 8;
            break;

        case "Dodecahedron":
            count = count + 12;
            break;

        default:
            count = count + 20;
            break;
    }

     
}

Console.WriteLine(count);
