namespace Decorator
{

    public interface IMailService
    {
        bool SendEmail(EmailDetail emailDetail);
    }

    public class AmazonMailService : IMailService
    {
        public bool SendEmail(EmailDetail emailDetail)
        {
            Console.WriteLine($"Email Sent To: {emailDetail.To} From: {emailDetail.From}, using Amazon email service.");
            return true;
        }
    }
    public class AzureMailService : IMailService
    {
        public bool SendEmail(EmailDetail emailDetail)
        {
            Console.WriteLine($"Email Sent To: {emailDetail.To} From: {emailDetail.From}, using Azure email service.");
            return true;
        }
    }

    // The above code is preimplemented, now you want to log the email details in data, for analysis,
    // In this case you can add decorator, which will log the details in DB and then send the email message.
    // This is nothing but a wrapper over the Mail, which will first log the email and then send the message
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;

        public MailServiceDecoratorBase(IMailService mailService)
        {
            this._mailService = mailService;
        }
        public virtual bool SendEmail(EmailDetail emailDetail)
        {
            return _mailService.SendEmail(emailDetail);
        }
    }

    public class DataBaseLoggerDecorator : MailServiceDecoratorBase
    {
        public DataBaseLoggerDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendEmail(EmailDetail emailDetail)
        {
            Console.WriteLine($"Log details in the database.");
            return base.SendEmail(emailDetail);
        }
    }

    public class FileBaseLoggerDecorator : MailServiceDecoratorBase
    {
        public FileBaseLoggerDecorator(IMailService mailService) : base(mailService)
        {
        }
        public override bool SendEmail(EmailDetail emailDetail)
        {
            Console.WriteLine($"Log details in the file.");
            return base.SendEmail(emailDetail);
        }
    }
}
