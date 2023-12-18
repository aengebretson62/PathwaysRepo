namespace MusicApi.Models
{
    public class MusicItem
    {
        public long id { get; set; }
        public string? songName { get; set; }

        public string? artistName { get; set; }
        public int rating { get; set; }
    }
}
