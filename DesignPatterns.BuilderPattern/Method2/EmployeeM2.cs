namespace DesignPatterns.BuilderPattern.Method2;
public sealed class EmployeeM2
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public override string ToString()
    {
        return $"{FirstName} {LastName} ({UserName})";
    }
}
