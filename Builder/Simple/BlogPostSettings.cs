namespace Builder.Simple
{
    public class BlogPostSettings
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public IList<string> Categories { get; set; }
    }
}
