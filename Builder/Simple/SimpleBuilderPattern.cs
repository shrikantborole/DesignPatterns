namespace Builder.Simple
{
    public interface IBlogPostBuilder
    {
        public  void AddTitle(string title);
        public  void AddContent(string body);
        public  void AddAuthor(string author);
        public  void AddDate(DateTime date);
        public  void AddCategory(string category);
        public BlogPostSettings Build();

    }

    public class FaceBookBlogPostBuilder : IBlogPostBuilder
    {
        private BlogPostSettings _blogPostSettings = new BlogPostSettings();
        public FaceBookBlogPostBuilder()
        {
            _blogPostSettings.Categories = new List<string>();
        }
        public  void AddTitle(string title)
        {
            _blogPostSettings.Title = $"FACEBOOK - {title}";
            Console.WriteLine($"FACEBOOK - {title}");
        }

        public  void AddContent(string body)
        {
            _blogPostSettings.Content = body;
        }

        public  void AddAuthor(string author)
        {
            _blogPostSettings.Author = author;
        }

        public  void AddDate(DateTime date)
        {
            _blogPostSettings.Date = date;
        }

        public  void AddCategory(string category)
        {
            _blogPostSettings.Categories.Add(category);
        }

        public BlogPostSettings Build()
        {
            return _blogPostSettings;
        }
    }

    public class SnapChatBlogPostBuilder : IBlogPostBuilder
    {
        private BlogPostSettings _blogPostSettings = new BlogPostSettings();
        public SnapChatBlogPostBuilder()
        {
            _blogPostSettings.Categories = new List<string>();
        }

        public  void AddTitle(string title)
        {
            _blogPostSettings.Title = $"SNAPCHAT - {title}";
            Console.WriteLine($"SNAPCHAT - {title}");
        }

        public  void AddContent(string body)
        {
            _blogPostSettings.Content = body;
        }

        public  void AddAuthor(string author)
        {
            _blogPostSettings.Author = author;
        }

        public  void AddDate(DateTime date)
        {
            _blogPostSettings.Date = date;
        }

        public  void AddCategory(string category)
        {
            _blogPostSettings.Categories.Add(category);
        }

        public BlogPostSettings Build()
        {
            return _blogPostSettings;
        }
    }

    public class SimpleBuilder
    {
        public void CallSimpleBuilder()
        {
            var facebookPostBuilder = new FaceBookBlogPostBuilder();

            facebookPostBuilder.AddTitle("FaceBookBlogPostBuilder");
            facebookPostBuilder.AddContent("This is FaceBookBlogPostBuilder");
            facebookPostBuilder.AddAuthor("FaceBookBlogPostBuilder Doe");
            facebookPostBuilder.AddDate(DateTime.Now);
            facebookPostBuilder.AddCategory("FaceBookBlogPostBuilder");
            facebookPostBuilder.AddCategory("FaceBookBlogPostBuilder");
            facebookPostBuilder.Build();

            var snapchatPostBuilder = new SnapChatBlogPostBuilder();
            snapchatPostBuilder.AddTitle("SnapChatBlogPostBuilder");
            snapchatPostBuilder.AddContent("This is SnapChatBlogPostBuilder");
            snapchatPostBuilder.AddAuthor("SnapChatBlogPostBuilder Doe");
            snapchatPostBuilder.AddDate(DateTime.Now);
            snapchatPostBuilder.AddCategory("SnapChatBlogPostBuilder");
            snapchatPostBuilder.AddCategory("SnapChatBlogPostBuilder");
            snapchatPostBuilder.Build();
        }
    }
}
