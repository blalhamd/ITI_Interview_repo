
using ITI_Interview;

public class Program
{
    private static void Main(string[] args)
    {
        // create employee object
        var employee = new Empolyee(1, "John Doe", 20000, 101);
        Console.WriteLine(employee.ToString());

        // create department object
        var department = new Department(101, "CS");
        Console.WriteLine(department.ToString());


        Console.ReadKey();
    }
}
