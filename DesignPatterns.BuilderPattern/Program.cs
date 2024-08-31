using DesignPatterns.BuilderPattern.Method1;
using DesignPatterns.BuilderPattern.Method2;
using System.Text;


var sb = new StringBuilder();

sb.Append("Tahsin");
sb.Append(" IŞIK");

var fullname = sb.ToString();

Console.WriteLine(fullname);

var eb = new EndpointBuilder("https://localhost");

eb.Append("api").Append("v1").Append("user").AppendParam("id", "5").AppendParam("user", "tahsin");

var url = eb.Build();
Console.WriteLine("Final Url : " + url);

var empBuilder = new EmployeeBuilderM1();

var employee = empBuilder.SetFullName("Tahsin IŞIK").SetUserName("tahsinisik23").SetEmailAddress("tahsinisik@gmail.com").BuildEmployee();

Console.WriteLine("M1 Employee FirstName: " + employee.FirstName);
Console.WriteLine("M1 Employee FirstName: " + employee.ToString());

IEmployeeBuilderM2 employeeBuilder = new InternalEmployeeBuilder();
employeeBuilder.SetEmailAddress("tahsinisik@gmail.com");
employeeBuilder.SetUserName("Tahsinisik");
employeeBuilder.SetFullName("Tahsin IŞIK");

var emp = employeeBuilder.BuildEmployee();

Console.WriteLine("Email Address: " + emp.EmailAddress);
Console.WriteLine("M2 Internal Employee: " + emp.ToString());

var empp = GenerateEmployee("Tahsin IŞIK", "tahsinisik@gmail.com", "tahsinisik23", 1);
Console.WriteLine(emp.ToString() + " Email Address: " + emp.EmailAddress);


EmployeeM2 GenerateEmployee(string fullName, string emailAddress, string userName, int empType)
{
    IEmployeeBuilderM2 employeeBuilder;
    if (empType == 0)
    {
        employeeBuilder = new InternalEmployeeBuilder();
    }
    else
    {
        employeeBuilder = new ExternalEmployeeBuilder();
    }
    employeeBuilder.SetFullName(fullName);
    employeeBuilder.SetEmailAddress(emailAddress);
    employeeBuilder.SetUserName(userName);
    return employeeBuilder.BuildEmployee();
}