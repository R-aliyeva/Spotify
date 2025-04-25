using Spotify.Application.DTOs;
using Spotify.Application.Interfaces;
using Spotify.Infrastructure.Services;
using Spotify.Domain.Interfaces;
using Spotify.Domain.Entities;


namespace Spotify.Application.Services
{
    public class MusicManager : IMusicService
    {
        private readonly IMusicRepository _musicrepository;
        public MusicManager()
        {
            _musicrepository=new MusicRepository();
        }
        public void Add(MusicCreateDto music)
        {
            _musicrepository.Add(new Music
            {
            Name = music.Name,
            AlbumId = music.AlbumId,
            Duration = music.Duration,
            
            });
        }

        public void Delete(int id)
        {
            _musicrepository.Delete(id);
        }

        public List<MusicDto> GetAllMusics()
        {
            var musics=_musicrepository.GetAll();
            var musicDto = new List<MusicDto>();
            foreach (var item in musics)
            {
                musicDto.Add(new MusicDto
                {
                    AlbumName = item.Album.Name,
                    Duration = item.Duration,
                    Name = item.Name,
                });
            }
            return musicDto;
        }

        public MusicDto GetByID(int id)
        {
            var music = _musicrepository.GetByID(id);
            var musicDto = new MusicDto
            {
                Id = music.Id,
                Name = music.Name,
                AlbumName=music.Album.Name,
                Duration=music.Duration,
            };
            return musicDto;
        }

        public void Update(MusicCreateDto music)
        {
            throw new NotImplementedException();
        }
    }
}
