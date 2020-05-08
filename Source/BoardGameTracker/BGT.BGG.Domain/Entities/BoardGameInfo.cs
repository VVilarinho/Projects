namespace BGT.BGG.Domain.Entities
{
    public class BoardGameInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearPublished { get; set; }
        public string Description { get; set; }
        public string ThumbnailURL { get; set; }
    }
}