using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Entities;

namespace Spotify.Infrastructure.DataContext
{
    public class AppDbContext:DbContext
    {
        public DbSet<Album> Albums { get; set; } = null!;
        public DbSet<Artist>Artists { get; set; } = null!;
        public DbSet<Music>Musics { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.\\MSSQLSERVER01;Database=Spotify4;Trusted_Connection=True;TrustServerCertificate=True");

        }
    }
}
