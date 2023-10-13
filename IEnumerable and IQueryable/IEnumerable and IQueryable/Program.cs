using IEnumerable_and_IQueryable;

internal class Program
{
    private static void Main(string[] args)
    {
        IEnum New_Enum = new IEnum();
        New_Enum.Test();

        Console.ReadKey();  
    }
}