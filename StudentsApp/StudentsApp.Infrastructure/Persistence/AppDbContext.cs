using Microsoft.EntityFrameworkCore;
using StudentsApp.Domain;

namespace StudentsApp.Infrastructure;

public class AppDbContext : DbContext //Kalıtım oluşturuldu
{

    public  DbSet<Student>Students{get; set;}
    public  DbSet<Lecture>Lectures{get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=StudentsAppDb;User Id=postgres;Password=mysecretpassword;");
    }
    //veritabanı tabloları
    //override onconfiguring
    //usenpsql
    //bağlantı adresi
}
