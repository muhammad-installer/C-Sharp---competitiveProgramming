using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        Console.WriteLine(timeConversion24to12(s));
    }
    static string timeConversion12to24(string s)
    {
        var hh = int.Parse(s.Substring(0, 2));

        if (s[8] == 'A' && hh == 12)
        {
            hh = 0;
        }
        else if (s[8] == 'P' && hh < 12)
        {
            hh += 12;
        }
        var result = $"{string.Format("{0:00}", hh)}:{s.Substring(3, 2)}:{s.Substring(6, 2)}";
        return result;
    }

    static string timeConversion24to12(string s)
    {
        var hh = int.Parse(s.Substring(0, 2));
        var ampm = "AM";
        if (hh == 0)
        {
            hh = 12;
        }
        else if (hh > 12)
        {
            hh -= 12;
            ampm = "PM";
        }
        else if (hh == 12)
        {
            ampm = "PM";
        }
        var result = $"{string.Format("{0:00}", hh)}:{s.Substring(3, 2)}:{s.Substring(6, 2)}:{ampm}";
        return result;
    }
}