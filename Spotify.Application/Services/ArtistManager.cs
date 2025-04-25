using Spotify.Application.DTOs;
using Spotify.Application.Interfaces;
using Spotify.Domain.Entities;
using Spotify.Domain.Interfaces;
using Spotify.Infrastructure.Services;


namespace Spotify.Application.Services
{
    public class ArtistManager : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        public ArtistManager()
        {
            _artistRepository=new ArtistRepository();
        }
        public void Add(ArtistCreateDto artist)
        {
            _artistRepository.Add(new Artist
            { 
                Bio=artist.Bio,
                Name=artist.Name,
                
           
            }
            );
        }

        public void Delete(int id)
        {
            _artistRepository.Delete(id);
        }

        public List<ArtistDto> GetAllArtist()
        {
            var artist=_artistRepository.GetAll();
            var artistDto=new List<ArtistDto>();
            foreach (var item in artist)
            { 
                artistDto.Add(new ArtistDto { Bio=item.Bio, Name=item.Name ,Id=item.Id});
            
            }
            return artistDto;
        }

        public ArtistDto GetByID(int id)
        {
            var artist = _artistRepository.GetByID(id);
            var artistDto = new ArtistDto
            {
                Id = artist.Id,
                Name = artist.Name,
                Bio = artist.Bio,
            };
            return artistDto;
        }

        public void Update(ArtistCreateDto artist)
        {
            throw new NotImplementedException();
        }
    }
}
