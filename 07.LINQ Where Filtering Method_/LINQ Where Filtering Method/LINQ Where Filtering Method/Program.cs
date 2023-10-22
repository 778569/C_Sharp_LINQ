using LINQ_Where_Filtering_Method;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {
        //Where_Test where_Test = new Where_Test();   
        ////where_Test.Test();
        //where_Test.Test2();


        //More_Where more_Where = new More_Where();
        //more_Where.Test();

        //Complex_Where complex_Where = new Complex_Where();
        //complex_Where.Test();


        //More_Where more_Where = new More_Where();
        //more_Where.Test2();

        //Complex_Where complex_Where = new Complex_Where();
        //complex_Where.Test();

        Complex_Where complex_Where1 = new Complex_Where();
        complex_Where1.Test_Using_Index();

        Console.ReadKey();
    }
}