namespace ChainOfResponsibility
{
    public class Document
    {
        public string? Name { get; set; }
        public string Title { get; set; }
        public string ApprovedBy { get; set; }

        public Document(string name, string title, string approvedBy)
        {
            Name = name;
            Title = title;
            ApprovedBy = approvedBy;
        }
    }

    //Handler
    public interface IHandler<T> where T : class
    {
        IHandler<T> SetSuccessor(IHandler<T> successor);
        void Handle(T request);
    }

    public class DocumentNameHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (document.Title == null)
            {
                throw new Exception("Titile is Empty");
                //You can add errors in the Error array and collect it at last, in case
                //if you don't want to break anything
            }
            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }

    public class DocumentTitleHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (document.Name == null)
            {
                throw new Exception("Name is Empty");
                //You can add errors in the Error array and collect it at last, in case
                //if you don't want to break anything
            }
            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }

    public class ApprovedByHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (document.ApprovedBy == null)
            {
                throw new Exception("ApprovedBy is Empty");
                //You can add errors in the Error array and collect it at last, in case
                //if you don't want to break anything
            }
            // go to the next handler
            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }
}