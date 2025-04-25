namespace Spotify.Application.DTOs
{
    public class MusicDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Duration { get; set; } 
        public required string AlbumName { get; set; }
       
    }
    public class MusicCreateDto 
    {
        public required string Name { get; set; }
        public int Duration { get; set; }
        public int AlbumId { get; set; }

    }
}
