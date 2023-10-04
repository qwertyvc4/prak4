namespace мдк3._1_пр4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2; // первый элемент прогрессии
            int r = 3; // знаменатель прогрессии
            int n = 5; // количество элементов прогрессии

            int result = a * (int)Math.Pow(r, n - 1);
            int sum = (a * (int)Math.Pow(r, n) - a) / (r - 1);

            Console.WriteLine("Последний элемент прогрессии: " + result);
            Console.WriteLine("Сумма прогрессии: " + sum);
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
}