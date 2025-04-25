namespace Spotify.Domain.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Bio {  get; set; }

        public List<Album> Albums { get; set; }=new List<Album>();
               
    }
}
