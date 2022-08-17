public class RoleService
{


    public List<Roles> AllRoles()
    {
        List<Roles> roles = new List<Roles>();

        roles.Add(new Roles() { Id = 1, Name = "TI", EmployeeId = 1 });
        roles.Add(new Roles() { Id = 2, Name = "Teste", EmployeeId = 2 });

        return roles;
    }

    public class Roles
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
