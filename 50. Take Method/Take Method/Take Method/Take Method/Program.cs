using Take_Method;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        TakeExample01 takeExample01 = new TakeExample01();
        //takeExample01.Test();
        //takeExample01.Test1();
        //takeExample01.Test2();

        ComplexTypeExample complexTypeExample = new ComplexTypeExample();
        complexTypeExample.Test();


        Console.ReadKey();

    }
}