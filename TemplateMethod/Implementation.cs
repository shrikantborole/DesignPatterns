namespace TemplateMethod
{ 
    public abstract class MailParser    {
        public virtual void FindServer()
        {
            Console.WriteLine("MailParser.FindServer()");
        }

        public abstract bool AuthenticateServer();

        // If we are confrim that the logic will not get change, then we remove virtual
        // keyword. In the below case we will able to override the method in the base class
        public virtual void ParseHtmlBody(string htmlBodyIdentifier)
        {
            Console.WriteLine($"MailParser.ParseHtmlBody() => {htmlBodyIdentifier}");
        }
        public void ParseMailBody(string mailBodyIdentifier)
        {
            FindServer();
            if (AuthenticateServer())
            {
                ParseHtmlBody(mailBodyIdentifier);
                Console.WriteLine($"MailParser.ParseMailBody() => {mailBodyIdentifier}");
            }
        }
    }

    public class AzureEmailParser : MailParser
    {
        public override bool AuthenticateServer()
        {
            Console.WriteLine("AzureEmailParser.AuthenticateServer()");
            return true;
        }
    }

    public class AmazonEmailParser : MailParser
    {
        public override void ParseHtmlBody(string htmlBodyIdentifier)
        {
            Console.WriteLine($"AmazonEmailParser.ParseHtmlBody() => {htmlBodyIdentifier}");
        }
        public override bool AuthenticateServer()
        {
            Console.WriteLine("AmazonEmailParser.AuthenticateServer()");
            return true;
        }
    }

    public class GoogleEmailParser : MailParser
    {
        public override void ParseHtmlBody(string htmlBodyIdentifier)
        {
            Console.WriteLine($"GoogleEmailParser.ParseHtmlBody() => {htmlBodyIdentifier}");
        }
        public override bool AuthenticateServer()
        {
            Console.WriteLine("GoogleEmailParser.AuthenticateServer()");
            return true;
        }
        public override void FindServer()
        {
            Console.WriteLine("GoogleEmailParser.FindServer()");
        }
    }
}
