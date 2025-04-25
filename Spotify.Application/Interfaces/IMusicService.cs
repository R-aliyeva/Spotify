using Spotify.Application.DTOs;

namespace Spotify.Application.Interfaces
{
    public interface IMusicService
    {
        void Add(MusicCreateDto music);
        void Update(MusicCreateDto music);
        void Delete(int id);
        List<MusicDto> GetAllMusics();
        MusicDto GetByID(int id);
    }
}
