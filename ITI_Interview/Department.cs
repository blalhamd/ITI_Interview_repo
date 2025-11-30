namespace ITI_Interview
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Empolyee> Empolyees { get; set; } = new List<Empolyee>();
    }
}
