
using ITI_Interview;

internal class Program
{
    private static void Main(string[] args)
    {
        double FirstNumber = 10;
        double SecondNumber = 20;
        double Sum = FirstNumber + SecondNumber;
        Console.WriteLine("The sum of {0} and {1} is {2}", FirstNumber, SecondNumber, Sum);

        var employee = new Empolyee
        {
            Id = 1,
            Name = "John Doe",
            Salary = 20000
        };

        Console.WriteLine("Employee Details: Id={0}, Name={1}, Salary={2} egy", employee.Id, employee.Name, employee.Salary);


        var department = new Department
        {
            Id = 101,
            Name = "IT"  
        };

        Console.WriteLine("Department Details: Id={0}, Name={1}", department.Id, department.Name);


        Console.ReadKey();
    }
}