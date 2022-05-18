using Microsoft.EntityFrameworkCore;

namespace linq_library_system.DataAccess.Model;

public class StudentDbContext: DbContext
{
    public virtual DbSet<Book> Books { get; set; }
    public  virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Publisher> Publishers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=WAIANGDESK13\MSSQLSERVER01;Initial Catalog=Books_Libirary;Integrated Security=True");
    }
}

