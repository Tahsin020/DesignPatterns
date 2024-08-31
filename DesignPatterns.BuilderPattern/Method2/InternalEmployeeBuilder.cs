﻿namespace DesignPatterns.BuilderPattern.Method2;
public sealed class InternalEmployeeBuilder : EmployeeBuilderM2
{
    public override void SetEmailAddress(string emailAddress)
    {
        var arr = emailAddress.Split('@');

        // endswith @company.com.tr

        Employee.EmailAddress = arr[0] + "@company.com.tr";
    }

    public override void SetFullName(string fullName)
    {
        var arr = fullName.Split(new[] { ' ', '_', '.' });

        Employee.FirstName = arr[0];
        Employee.LastName = arr[1];
    }

    public override void SetUserName(string userName)
    {
        Employee.UserName = userName;
    }
}
