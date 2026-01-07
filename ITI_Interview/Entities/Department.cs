namespace ITI_Interview.Entities
{
    public class Department
    {
        public Guid DepartmentId { get; private set; }
        public string Name { get; private set; } = null!;
        public ICollection<Empolyee> Empolyees { get; private set; } = new List<Empolyee>();

        private Department() { }

        private Department(string name)
        {
            DepartmentId = Guid.NewGuid();
            Name = name;
        }

        public static Department Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("Name cannot be null or empty.");

            return new Department(name);
        }

        public void AddEmpolyee(Empolyee empolyee)
        {
            if (empolyee is null)
                throw new ArgumentNullException("Empolyee cannot be null.");
            Empolyees.Add(empolyee);
        }

        public Department Update(string name)
        {
            if (string.IsNullOrEmpty(name))
              throw new ArgumentNullException("Department name cannot be null or empty.");
            Name = name;
            return this;
        }

        public override string ToString()
        {
            return string.Format("\nDepartment Details: Id={0}, Name={1}\n", DepartmentId.ToString().Substring(0,5), Name);
        }
    }
}
