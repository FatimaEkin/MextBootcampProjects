// See https://aka.ms/new-console-template for more information




public abstract class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }

    public abstract decimal CalculateMonthlySalary();
}



public class FullTimeEmployee : Employee
{
    public decimal MonthlySalary { get; set; }

    public override decimal CalculateMonthlySalary()
    {
        return MonthlySalary;
    }
}

public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public override decimal CalculateMonthlySalary()
    {
        return HourlyRate * HoursWorked;
    }
}


public class Freelancer : Employee
{
    public decimal ProjectRate { get; set; }
    public int ProjectsCompleted { get; set; }

    public override decimal CalculateMonthlySalary()
    {
        return ProjectRate * ProjectsCompleted;
    }
}
