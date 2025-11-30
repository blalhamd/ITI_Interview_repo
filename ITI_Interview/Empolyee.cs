namespace ITI_Interview
{
    public class Empolyee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}
