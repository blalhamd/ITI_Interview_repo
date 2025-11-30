
using ITI_Interview;

internal class Program
{
    private static void Main(string[] args)
    {
        // simple addition
        double FirstNumber = 100;
        double SecondNumber = 20;
        double Sum = FirstNumber + SecondNumber;
        Console.WriteLine("The sum of {0} and {1} is {2}\n", FirstNumber, SecondNumber, Sum);

        // create employee object
        var employee = new Empolyee
        {
            Id = 1,
            Name = "John Doe",
            Salary = 20000,
            DepartmentId = 101
        };

        Console.WriteLine(employee);

        // create department object
        var department = new Department
        {
            Id = 101,
            Name = "CS"  
        };

        Console.WriteLine("\nDepartment Details: Id={0}, Name={1}\n", department.Id, department.Name);


        Console.ReadKey();
    }
}
