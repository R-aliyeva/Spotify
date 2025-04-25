namespace Spotify.Application.DTOs
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
       
        public required string ArtistName {  get; set; }
    }
    public class AlbumCreateDto 
    {
        public required string Name { get; set; }
        public int ArtistId { get; set; }
       

    }
}
