using First_and_FirstOrDefault;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        FirstExample01 firstExample01 = new FirstExample01();
        //firstExample01.Test();
        //firstExample01.Test1();
        //firstExample01.Test2();

        FirstOrDefaultExample firstOrDefaultExample = new FirstOrDefaultExample();
        //firstOrDefaultExample.Test();
        FirstOrDefaultExample01 firstOrDefaultExample01 = new FirstOrDefaultExample01();
        //firstOrDefaultExample01.Test();
        EmployeeTest employeeTest = new EmployeeTest();
        //employeeTest.Test();
        employeeTest.Test1();

        Console.ReadKey();
    }
}