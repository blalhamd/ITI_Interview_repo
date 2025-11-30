
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

        Console.ReadKey();
    }
}