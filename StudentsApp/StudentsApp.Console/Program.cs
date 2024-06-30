// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Caching.Memory;
using StudentsApp.Domain;
using StudentsApp.Infrastructure;


Console.WriteLine("Hello, World!");

 AppDbContext context = new();

 MemoryCache cache = new(new MemoryCacheOptions()
 {
  ExpirationScanFrequency = TimeSpan.FromDays(1),
 });

var lecturesFromCache = cache.Get<List<Lecture>>("LecturesCacheKey");
List<Lecture> lectures = null;
if(lecturesFromCache == null)
{
    lectures = context.Lectures.ToList();
    cache.Set("lecturesCacheKey", lectures);
   }

 //cache.Set("StudentsCacheKey", students);
 MemoryCache cache1 = new(new MemoryCacheOptions()
 {
  ExpirationScanFrequency = TimeSpan.FromDays(1),
 });


var StudentsFromCache = cache.Get<List<Student>>("StudentsCacheKey");
List<Student> students = null;
if(StudentsFromCache == null)
{
    students = context.Students.ToList();
    cache.Set("studentsCacheKey", students);
   }
 //cache.Set("StudentsCacheKey", lectures);

 //var students = context.Students.ToList();

//cache.Set("Students", students);

// Student student = new Student()
// {
//     Id = Guid.NewGuid(),
//     Name = "Gizem Ak",
//     Grade = GradeLevel.Junior,
// } ;
    

// Student student2 = new()
// {
//      Id = Guid.NewGuid(),
//      Name = "Enes Demir",
//      Grade = GradeLevel.Senior,
//  };
   
//  Lecture lecture = new Lecture()
//  {
//   Id = Guid.NewGuid(),
//   Title = "xyz",
//   Type = LectureType.Hybrid
//  };
//     context.Students.Add(student);
//     context.Students.Add(student2);
//     context.Lectures.Add(lecture);
//     context.SaveChanges();
//     Console.WriteLine($"Öğrenci İsmi: {student.Name} - Öğrenci Sınıfı: {student.Grade}");
//     Console.WriteLine($"Başlık: {lecture.Title} - Tipi: {lecture.Type}");

 