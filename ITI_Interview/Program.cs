public partial class Program
{
    private static void Main(string[] args)
    {
        // create employee object
        var employee = new Empolyee(1, "Mohamed Mahed", 20000, 101);
        Console.WriteLine(employee);

        // create department object
        var department = new Department(101, "CS");
        Console.WriteLine(department);

        // create manager object
        var manager = new Manager(1, "Khaled Nady");
        Console.WriteLine(manager);

        Console.ReadKey();
    }
}
