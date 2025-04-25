namespace Spotify.Domain.Entities
{
    public class Music
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Duration{ get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; } = null!;


    }
}
