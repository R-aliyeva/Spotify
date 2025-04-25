namespace Spotify.Domain.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int ArtistId { get; set; }
        public Artist Artist { get; set; } = null!;
        public List<Music> Musics { get; set; } = new List<Music>();
    }
}
