namespace BUSINESSREQUIREMENTS
{
    public sealed record Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        private Employee(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public static bool IsUnder60(Employee employee)
        {
            if (employee is null)
                throw new ArgumentNullException(nameof(employee));
            return employee.Age < 60;
        }

        public static Employee Create(int id, string name, int age) => new Employee(id, name, age);
    }
}
