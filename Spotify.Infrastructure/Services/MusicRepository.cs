using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Entities;
using Spotify.Domain.Interfaces;
using Spotify.Infrastructure.DataContext;

namespace Spotify.Infrastructure.Services
{
    public class MusicRepository:EfCoreRepository<Music>,IMusicRepository
    {
      
        public override List<Music> GetAll()
        {
            return _context.Set<Music>().Include(x=>x.Album).ThenInclude(x=>x.Artist).ToList();
        }
    }
}
