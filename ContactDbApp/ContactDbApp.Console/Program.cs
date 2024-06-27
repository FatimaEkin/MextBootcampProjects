// See https://aka.ms/new-console-template for more information
using System.Formats.Asn1;
using System.Net.Http.Headers;
using ContactDbApp.Console;

ContactDbAppContext context = new();

// Student student1 = new()
// {
//     Id = Guid.NewGuid(),
//     Name = "Ahmet Ak",
//     Grade = GradeLevel.Junior,
// };

// Student student2 = new()
// {
//     Id = Guid.NewGuid(),
//     Name = "Aslı Demir",
//     Grade = GradeLevel.Junior,
// };

// context.Students.Add(student1);
// context.Students.Add(student2);
// context.SaveChanges();

// var students = context.Students.ToList();

// foreach(var student in students)
// {
//     Console.WriteLine($"{student.Name} - {student.Grade}");
// }

string secim = "";

while(secim!="3")
{
Console.WriteLine("1- Ekle");
Console.WriteLine("2- Görüntüle");
Console.WriteLine("3- Çıkış");
Console.WriteLine("Seçim yapınız: ");
secim = Console.ReadLine();

