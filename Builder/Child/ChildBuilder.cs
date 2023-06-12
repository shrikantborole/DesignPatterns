using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Child
{
    public interface IBookBuilder
    {
        BookCoverBuilder AddBookCover();
        BookChapterBuilder AddChapter();
        Book Build();
    }

    public class BookBuilder : IBookBuilder
    {
        private readonly Book _book = new Book();

        public BookBuilder()
        {
            _book.Chapters = new List<Chapter>();
        }

        public BookCoverBuilder AddBookCover()
        {
            return new BookCoverBuilder(this, _book);
        }

        public BookChapterBuilder AddChapter()
        {
            return new BookChapterBuilder(this, _book);
        }

        public Book Build()
        {
            return _book;
        }
    }

    public class BookCoverBuilder
    {
        private readonly BookBuilder _parentBookBuilder;
        private readonly Book _book;

        public BookCoverBuilder(BookBuilder parentBookBuilder, Book book)
        {
            _parentBookBuilder = parentBookBuilder;
            _book = book;
        }

        public BookCoverBuilder WithTitle(string title)
        {
            _book.Title = title;
            return this;
        }

        public BookCoverBuilder WithAuthor(string author)
        {
            _book.Author = author;
            return this;
        }

        public BookCoverBuilder WithPublisher(string publisher)
        {
            _book.Publisher = publisher;
            return this;
        }

        public BookChapterBuilder AddChapter()
        {
            return _parentBookBuilder.AddChapter();
        }
    }
    public class BookChapterBuilder
    {
        private readonly BookBuilder _parentBookBuilder;
        private readonly Book _book;

        private readonly Chapter _chapter = new Chapter();

        public BookChapterBuilder(BookBuilder parentBookBuilder, Book book)
        {
            _parentBookBuilder = parentBookBuilder;
            _book = book;
        }

        public BookChapterBuilder WithTitle(string title)
        {
            _chapter.Title = title;
            return this;
        }

        public BookChapterBuilder WithContent(string content)
        {
            _chapter.Content = content;
            return this;
        }

        public BookChapterBuilder WithOpeningQuote(string openingQuote)
        {
            _chapter.OpeningQuote = openingQuote;
            return this;
        }

        public BookChapterBuilder AddChapter()
        {
            _book.Chapters.Add(_chapter);
            return _parentBookBuilder.AddChapter();
        }

        public Book Build()
        {
            _book.Chapters.Add(_chapter);
            return _parentBookBuilder.Build();
        }
    }
    public class ChildBuilder
    {
        public void CallChildBuilder()
        {
            //Need to Think
        }
    }
}
