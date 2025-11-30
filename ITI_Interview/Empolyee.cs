namespace ITI_Interview
{
    public class Empolyee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public override string ToString()
        {
            return $"Employee Details: Id={Id}, Name={Name}, Salary={Salary} egy, DepartmentId={DepartmentId}";
        }
    }
}
