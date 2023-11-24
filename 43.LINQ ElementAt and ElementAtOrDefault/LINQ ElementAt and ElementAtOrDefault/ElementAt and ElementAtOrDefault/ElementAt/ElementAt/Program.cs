using ElementAt;

internal class Program
{
    private static void Main(string[] args)
    {
       Example01 example01 = new Example01();
        //example01.Test();

        ElementAtOrDefault elementAtOrDefault = new ElementAtOrDefault();

        //elementAtOrDefault.Test();

        Example02 example02 = new Example02();
        example02.Test();

       Console.ReadKey();

    }
}