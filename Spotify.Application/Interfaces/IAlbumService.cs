using Spotify.Application.DTOs;

namespace Spotify.Application.Interfaces
{
    public interface IAlbumService
    {
        void Add(AlbumCreateDto album);
        void Update(AlbumCreateDto album);
        void Delete(int id);
        List<AlbumDto> GetAllAlbums();
        AlbumDto GetByID(int id);

    }
}
