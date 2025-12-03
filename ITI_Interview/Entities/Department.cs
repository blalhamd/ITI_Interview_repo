namespace ITI_Interview.Entities
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public ICollection<Empolyee> Empolyees { get; private set; } = new List<Empolyee>();

        public Department(int id, string name)
        {
            SetId(id);
            SetName(name);
        }

        private void SetId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Id must be greater than zero.");
            Id = id;
        }

        public void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be null or empty.");
            Name = name;
        }

        public void AddEmpolyee(Empolyee empolyee)
        {
            if (empolyee == null)
                throw new ArgumentNullException(nameof(empolyee), "Empolyee cannot be null.");
            Empolyees.Add(empolyee);
        }

        public override string ToString()
        {
            return string.Format("\nDepartment Details: Id={0}, Name={1}\n", Id, Name);
        }
    }
}
