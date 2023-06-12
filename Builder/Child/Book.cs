namespace Builder.Child
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public IList<Chapter> Chapters { get; set; }
    }
}
