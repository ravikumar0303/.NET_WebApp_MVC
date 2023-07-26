using Microsoft.EntityFrameworkCore;
using BOL;

namespace DAL;
public class CollectionContext : DbContext
{
    public DbSet<Department> Departments { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = @"server=192.168.10.150;port=3306;user=dac57; password=welcome;database=dac57";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Set Mapping of Table with POCO
        //Relational        instance: Table
        //Object Oriented   instance: POCO Class
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Deptno);
            entity.Property(e => e.Dname).IsRequired();
            entity.Property(e => e.Loc).IsRequired();
            entity.Property(e => e.pwd).IsRequired();
            entity.Property(e => e.StartedON).IsRequired();
        });
        modelBuilder.Entity<Department>().ToTable("dept");
    }
}

