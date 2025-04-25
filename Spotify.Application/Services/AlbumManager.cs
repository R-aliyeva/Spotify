using Microsoft.EntityFrameworkCore;
using Spotify.Application.DTOs;
using Spotify.Application.Interfaces;
using Spotify.Domain.Entities;
using Spotify.Domain.Interfaces;
using Spotify.Infrastructure.Services;

namespace Spotify.Application.Services
{
    public class AlbumManager : IAlbumService
    {
        private readonly IAlbumRepository _albumrepository;
        public AlbumManager()
        {
            _albumrepository=new AlbumRepository();
        }
        public void Add(AlbumCreateDto album)
        {
            //_albumrepository.Add(new Album { Name = album.Name, ArtistId = album.ArtistId });
            //_albumrepository.Add(new Album { Name = "Test Albüm", ArtistId = 1 });
           
                _albumrepository.Add(new Album { Name = album.Name, ArtistId = album.ArtistId });
            
           
        }

        public void Delete(int id)
        {

            _albumrepository.Delete(id);
        }

        public List<AlbumDto> GetAllAlbums()
        {
            var albums=_albumrepository.GetAll();
            var albumDto=new List<AlbumDto>();
            foreach (var album in albums) 
            {
                albumDto.Add(new AlbumDto
                {
                    Id = album.Id,
                    Name = album.Name,
                    ArtistName=album.Artist.Name
               
                });
            }
            return albumDto;
        }

        public AlbumDto GetByID(int id)
        {
            var album=_albumrepository.GetByID(id);
            var albumDto=new AlbumDto 
            { 
                Id = album.Id ,
                Name=album.Name,
                ArtistName = album.Artist.Name
            };
            return albumDto;
        }

        public void Update(AlbumCreateDto album)
        {
            throw new NotImplementedException();
        }
    }
}
