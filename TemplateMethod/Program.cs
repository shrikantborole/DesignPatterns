using TemplateMethod;

Console.Title = "Template Method";

MailParser googleEmailParser = new GoogleEmailParser();
googleEmailParser.ParseMailBody("ff3f5f39-02df-48fc-9c20-fe115ed106be");
Console.WriteLine("--------------------------------");
MailParser amazonEmailParser = new AmazonEmailParser();
amazonEmailParser.ParseMailBody("b674ee65-5c07-45f2-8c2c-f333d2b1d169");
Console.WriteLine("--------------------------------");
MailParser azureEmailParser = new AzureEmailParser();
azureEmailParser.ParseMailBody("12aacaff-0db3-4231-8923-bc60c5f27f0a");
