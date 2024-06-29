namespace StudentsApp.Domain;

public class Student : EntityBase
{
//public Guid Id {get; set;}
public string Name {get; set;}
public GradeLevel Grade {get; set;}
}
