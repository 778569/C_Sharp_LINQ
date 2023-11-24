using DefaultIfEmpty;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");


        Example01 example01 = new Example01();
        //example01.Test3();

        ComplexExample complexExample = new ComplexExample();
        //complexExample.Test();

        DefaultIfEmptyWithJoin defaultIfEmptyWithJoin = new DefaultIfEmptyWithJoin();
        defaultIfEmptyWithJoin.Test();

        Console.ReadKey();

    }
}