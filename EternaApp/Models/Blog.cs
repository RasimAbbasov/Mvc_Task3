namespace EternaApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImgName { get; set; }
        public string AuthorName { get; set; }
        public DateTimeOffset CreatedDate { get; set; } = new();
    }
}
