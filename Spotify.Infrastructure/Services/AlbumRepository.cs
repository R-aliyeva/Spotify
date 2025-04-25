using Microsoft.EntityFrameworkCore;
using Spotify.Domain.Entities;
using Spotify.Domain.Interfaces;

namespace Spotify.Infrastructure.Services
{
    public class AlbumRepository:EfCoreRepository<Album>,IAlbumRepository   
    {
        public override List<Album> GetAll()
        {
            return _context.Set<Album>().Include(x => x.Artist).ToList();
        }
    }
}
