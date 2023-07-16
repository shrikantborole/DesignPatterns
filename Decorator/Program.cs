using Decorator;

Console.Title = "Decorator";

DataBaseLoggerDecorator dataBaseLoggerDecorator = 
    new DataBaseLoggerDecorator(
     new AmazonMailService()
    );
dataBaseLoggerDecorator.SendEmail(new EmailDetail
    ()
{
    To = "shrikant.borole@gmail.com",
    From = "shrikant.borole@amazon.com"
});


DataBaseLoggerDecorator dataBaseLoggerDecoratorAzure =
    new DataBaseLoggerDecorator(
     new AzureMailService()
    );
dataBaseLoggerDecoratorAzure.SendEmail(new EmailDetail
    ()
{
    To = "shrikant.borole@gmail.com",
    From = "shrikant.borole@amazon.com"
});

