public partial class Program
{
    public class Manager
    {
        public int Id { get; private set; }
        public string FullName { get; private set; } = null!;

        public Manager(int id, string fullName)
        {
            SetId(id);
            SetName(fullName);
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
            FullName = name;
        }

        // يحسب الضريبة 10%
        public double CalculateTax(double salary)
        {
            return salary * 0.10;
        }

        public override string ToString()
        {
            return $"Manager [Id={Id}, Name={FullName}]";
        }
    }
}
