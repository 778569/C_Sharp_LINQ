internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        IEnumerable<int> firstFive = numbers.Take(5);

        Console.WriteLine("First Five: " + string.Join(", ", firstFive));

        IEnumerable<int> lessThanSix = numbers.TakeWhile(n => n < 6);

        Console.WriteLine("Less than Six : "  + string.Join(", " , lessThanSix));

        IEnumerable<int> SkipFirstFive = numbers.Skip(5);

        Console.WriteLine("Skip First Five : " + string.Join(", ", SkipFirstFive));

        IEnumerable<int> SkipLessThanSix = numbers.SkipWhile(n => n < 5);

        Console.WriteLine("Skip Less Than Six: " + string.Join(", ", SkipLessThanSix));

        Console.ReadKey();
    }
}