namespace Spotify.Application.DTOs
{
    public class ArtistDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Bio { get; set; }

      
    }
    public class ArtistCreateDto 
    {
        public required string Name { get; set; }

        public required string Bio { get; set; }
       
    }
}
