using Microsoft.EntityFrameworkCore;

namespace MovieMvc.Models
{
    public class MovieMvcContext: DbContext
    {
        public MovieMvcContext(DbContextOptions<MovieMvcContext> options)
            : base(options)
        {
            
        }

        public DbSet<MovieMvc.Models.Movie> Movie{ get; set; }
    }
}