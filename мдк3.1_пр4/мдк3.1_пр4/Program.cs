internal class Program
{
    static void Main(string[] args)
    {
        string filePath = "CMakeList.txt";
        string words = Console.ReadLine();
        File.WriteAllText(filePath, words);     
    }
    public static string Formatter(string message)
    {
        string res = string.Empty;
        res += "-------------------------\n";
        res += message + "\n";
        res += "-------------------------\n";
        return res;
    }
}
