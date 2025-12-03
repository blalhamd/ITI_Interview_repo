
using ITI_Interview;

public class Program
{
    public class Manager
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } 

        public Manager(int id, string name)
        {
            SetId(id);
            SetName(name);
        }

        private void SetId(int id)
        {
            if(id <= 0)
                throw new ArgumentException("Id must be greater than zero.");
            Id = id;
        }
        
        public void SetName(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            Name = name;
        }

        public double CalculateTax(double salary)
        {
            return salary * 0.20;
        }

        public override string ToString()
        {
            return $"Manager [Id={Id}, Name={Name}]";
        }
    }

    private static void Main(string[] args)
    {
        // create employee object
        var employee = new Empolyee(1, "John Doe", 20000, 101);
        Console.WriteLine(employee.ToString());

        // create department object
        var department = new Department(101, "CS02");
        Console.WriteLine(department.ToString());

        // create manager object
        var manager = new Manager(1, "Jane Smith");
        Console.WriteLine(manager.ToString());

        Console.ReadKey();
    }
}
