internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        List<int> intList = new List<int>() { 10, 45, 35, 29, 100, 69, 58, 50 };

        var OrderDes = intList.OrderByDescending(num=>num).ToList();

        var OrderDesQS = (from num in intList
                          orderby num descending
                          select num).ToList();


        foreach (var item in OrderDes)
        {
            Console.Write(item + " ");
        }

        Console.ReadKey();
    }
}