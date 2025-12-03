
using ITI_Interview;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Amazing App [Version 2.0]");

        // create employee object
        var employee = new Empolyee(1, "John Doe", 20000, 101);
        Console.WriteLine(employee.ToString());

        // create department object
        var department = new Department(101, "CS02");
        Console.WriteLine(department.ToString());


        Console.ReadKey();
    }
}
