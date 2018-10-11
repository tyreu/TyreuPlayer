namespace TyreuPlayer
{
    public class Track
    {
        public Track() { }
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public bool IsLike { get; set; }
        public override string ToString() => !string.IsNullOrEmpty(Artist) && !string.IsNullOrEmpty(Title) ? $"{Artist} - {Title}" : Name;
    }
}
