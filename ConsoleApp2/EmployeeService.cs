public class EmployeeService
{
    RoleService roleService;
    public EmployeeService()
    {
        roleService = new RoleService();
    }
    public List<Employee> AllEmployee()
    {
        List<Employee> roles = new List<Employee>();

        roles.Add(new Employee() { Id = 1, Name = "Juca" });
        roles.Add(new Employee() { Id = 2, Name = "Joao" });

        return roles;
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public List<string> GetEmployeeRoleByName(string name)
    {
        var employeeId = AllEmployee().Where(x => x.Name == name).Select(x=>x.Id).FirstOrDefault();
        return roleService.AllRoles().Where(x => x.EmployeeId == employeeId).Select(x=>x.Name).ToList();
    }
}
