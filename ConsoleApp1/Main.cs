// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var employeeService = new EmployeeService();
Console.WriteLine(employeeService.GetEmployeeRoleByName("Joao").First());
Console.WriteLine("-----");
