internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        var numbers = new int[] {1,2,3 };

        var firstNumber = numbers.First();
        Console.WriteLine("First Number = "+firstNumber +"\n");

        var firstEvenNumber = numbers.Where(n=>n % 2 ==0).FirstOrDefault();
        Console.WriteLine("First Even Number = " + firstEvenNumber +"\n");
        
        var singleNumber = numbers.Single(n=>n==3);
        Console.WriteLine("Single Number = " + singleNumber + "\n");

        var thirdNumber = numbers.ElementAtOrDefault(2);
        Console.WriteLine("Single Number = " + thirdNumber + "\n");

        var fourthNumber = numbers.ElementAtOrDefault(3);
        Console.WriteLine("Fourth Number = " + fourthNumber + "\n");

        Console.ReadKey();
    }
}