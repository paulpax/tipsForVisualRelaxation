using tipsForVisualRelaxation.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace tipsForVisualRelaxation.DataAccessLayer
{
    public class MovieContext : DbContext
    {

        public MovieContext() : base ("MovieContext")
        {
        }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}