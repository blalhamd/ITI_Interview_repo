namespace ITI_Interview
{
    public class Empolyee
    {
        
        public int Id { get; private set; }
        public string Name { get; private set; } = null!;
        public double Salary { get; private set; }
        public int DepartmentId { get; private set; }
        public Department Department { get; private set; } = null!;

        public Empolyee(int id, string name, double salary, int departmentId, Department? department = null)
        {
            SetId(id);
            SetName(name);
            SetSalary(salary);
            SetDepartmentId(departmentId);
            if (department != null)
            {
                SetDepartment(department);
            }
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

        public void SetSalary(double salary)
        {
            if(salary < 0)
                throw new ArgumentException("Salary cannot be negative.");
            Salary = salary;
        }

        public void SetDepartmentId(int departmentId)
        {
            if(departmentId <= 0)
                throw new ArgumentException("DepartmentId must be greater than zero.");
            DepartmentId = departmentId;
        }

        public void SetDepartment(Department department)
        {
            Department = department ?? throw new ArgumentNullException(nameof(department), "Department cannot be null.");
        }

        public override string ToString()
        {
            return string.Format("Employee Details: Id={0}, Name={1}, Salary={2} egy, DepartmentId={3}", Id, Name, Salary, DepartmentId);
        }

    }
}
