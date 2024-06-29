namespace StudentsApp.Domain;

public class Lecture : EntityBase
{
//public Guid Id { get; set; }
public string Title { get; set; }
public LectureType Type { get; set; }
}
