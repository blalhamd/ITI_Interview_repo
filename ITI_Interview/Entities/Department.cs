namespace ITI_Interview.Entities
{
    public class Department
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public ICollection<Empolyee> Empolyees { get; private set; } = new List<Empolyee>();

        private Department() { }

        private Department(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public static Department Create(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");

            return new Department(name);
        }

        public void AddEmpolyee(Empolyee empolyee)
        {
            if (empolyee == null)
                throw new ArgumentNullException(nameof(empolyee), "Empolyee cannot be null.");
            Empolyees.Add(empolyee);
        }

        public override string ToString()
        {
            return string.Format("\nDepartment Details: Id={0}, Name={1}\n", Id.ToString().Substring(0,5), Name);
        }
    }
}
