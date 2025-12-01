
using ITI_Interview;

internal class Program
{
    private static void Main(string[] args)
    {
        // create employee object
        var employee = new Empolyee(1, "John Doe", 20000, 101);
        Console.WriteLine(employee);

        // create department object
        var department = new Department(101, "MM");
        Console.WriteLine("\nDepartment Details: Id={0}, Name={1}\n", department.Id, department.Name);


        Console.ReadKey();
    }
}
