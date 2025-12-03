public partial class Program
{
    private static void Main(string[] args)
    {
        // create employee object
        var employee = new Empolyee(1, "John Doe", 20000, 101);
        Console.WriteLine(employee);

        // create department object
        var department = new Department(101, "CS02");
        Console.WriteLine(department);

        // create manager object
        var manager = new Manager(1, "Jane Smith");
        Console.WriteLine(manager);

        Console.ReadKey();
    }
}
