using Microsoft.EntityFrameworkCore;
using FilmesAPI.Models;

namespace FilmesApi.Data
{
    public class FilmeContext: DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base (opt)
        {
            
        }
        public DbSet<Filme> filmes { get; set; }
    }
}