using MenuClassLib.Models;
using Microsoft.EntityFrameworkCore;

namespace MenuClassLib.Data
{
    public class MenuContext : DbContext
    {


        //As per CSharpFritz, this is the correct way to set up a
		//SQLite context.  No constructor.  Just the OnConfiguring override
        //
        // And the same works for the EF In Memory database
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	    {

            optionsBuilder.UseInMemoryDatabase(databaseName: "Menudb");

			base.OnConfiguring(optionsBuilder);
		}
        public DbSet<Menu> Menu { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
    }
}