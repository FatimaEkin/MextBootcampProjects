using Microsoft.EntityFrameworkCore;

namespace ContactDbApp.Console;

public class ContactDbAppContext : DbContext
{
public DbSet<Student>Students {get; set;}
public DbSet<Teacher>Teachers {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=myDataBase;User Id=postgres;Password=mysecretpassword;");
    }
}


