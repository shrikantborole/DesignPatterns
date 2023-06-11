using Builder.Simple;

namespace Builder.Fluent
{
    public class FluentBlogPostBuilder
    {
        private readonly BlogPostSettings _blogPostSettings = new BlogPostSettings();
        public FluentBlogPostBuilder()
        {
            _blogPostSettings.Categories = new List<string>();

        }
        public FluentBlogPostBuilder WithTitle(string title)
        {
            _blogPostSettings.Title = title;
            return this;
        }

        public FluentBlogPostBuilder WithContent(string body)
        {
            _blogPostSettings.Content = body;
            return this;
        }

        public FluentBlogPostBuilder WithAuthor(string author)
        {
            _blogPostSettings.Author = author;
            return this;
        }

        public FluentBlogPostBuilder WithDate(DateTime date)
        {
            _blogPostSettings.Date = date;
            return this;
        }

        public FluentBlogPostBuilder WithCategory(string category)
        {
            _blogPostSettings.Categories.Add(category);
            return this;
        }
        public BlogPostSettings Build()
        {
            return _blogPostSettings;
        }
    }

    public class FluentBuilder
    {
        public void CallFluentBuilder()
        {
            var blogPostBuilder = new FluentBlogPostBuilder();

            var blogPost = blogPostBuilder
                .WithTitle("My First Blog Post")
                .WithContent("This is my first blog post")
                .WithAuthor("John Doe")
                .WithDate(DateTime.Now)
                .WithCategory("C#")
                .Build();
            Console.WriteLine($"{blogPost.Title}-{blogPost.Content}-{blogPost.Author}-{blogPost.Date}-Category Count:- {blogPost.Categories.Count}");
        }
    }
}
