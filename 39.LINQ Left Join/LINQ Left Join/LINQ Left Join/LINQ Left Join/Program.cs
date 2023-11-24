using LINQ_Left_Join;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        Example01 example01 = new Example01();
        //example01.Test();
        Example03RightOuterJoin example03RightOuterJoin = new Example03RightOuterJoin();
        //example03RightOuterJoin.Test();
        RealTimeExample realTimeExample = new RealTimeExample();
        realTimeExample.Test();

        Console.ReadKey();
    }
}