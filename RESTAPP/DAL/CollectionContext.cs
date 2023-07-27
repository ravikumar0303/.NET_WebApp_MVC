using Microsoft.EntityFrameworkCore;
using BOL;
namespace DAL;

public class CollectionContext:DbContext
{

    public DbSet<Product> Products { get; set; }

    //public CollectionContext(DbContextOptions<CollectionContext> options):base(options)

    protected override void OnConfiguring(DbContextOptionsBuilder options){
        string constring = @"server=192.168.10.150;port=3306;uid=dac60;password=welcome;database=dac60";
        options.UseMySQL(constring);
    }

}
