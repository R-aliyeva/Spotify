using Spotify.Domain.Entities;
using Spotify.Domain.Interfaces;

namespace Spotify.Infrastructure.Services
{
    public class ArtistRepository:EfCoreRepository<Artist>,IArtistRepository
    {
    }
}
