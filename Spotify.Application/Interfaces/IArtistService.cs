using Spotify.Application.DTOs;

namespace Spotify.Application.Interfaces
{
    public interface IArtistService
    {
        void Add(ArtistCreateDto artist);
        void Update(ArtistCreateDto artist);
        void Delete(int id);
        List<ArtistDto> GetAllArtist();
        ArtistDto GetByID(int id);
    }
}
