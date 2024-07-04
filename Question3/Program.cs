internal class Program
{
    private static void Main(string[] args)
    {
        string firstName = "  Kirisame";
        string lastName = "Marisa";
        string fullName = $"{firstName} {lastName}";
        Console.WriteLine(fullName);
        string description = "Black Magician  ";
        string result = String.Concat(fullName, " ", description);
        Console.WriteLine(result);
        //To upper
        Console.WriteLine(result.ToUpper());
        //To lower
        Console.WriteLine(result.ToLower());
        //length
        Console.WriteLine(result.Length);
        //IndexOf(1): find the index of character
        Console.WriteLine(result.IndexOf('a'));
        //IndexOf(2): find the index of character starting from
        Console.WriteLine(result.IndexOf('a', 4));
        //Count the occurence of a specific character from string
        Console.WriteLine(result.Count(ch => ch == 'i'));
        //Replace
        Console.WriteLine(result.Replace("Kirisame","Marisa"));
        //Remove
        Console.WriteLine(result.Remove(16));
        //Replace
        Console.WriteLine(result.Replace('i','⭐'));
        //Substring
        string substring1 = result.Substring(0,8);
        Console.WriteLine(substring1);
        //Trim: loai bo khoang trang o dau va cuoi
        Console.WriteLine(result.Trim());

        string birthYear = "1995";
        int birthYearAfterChange = int.Parse(birthYear);
        Console.WriteLine(birthYearAfterChange);
    }
}