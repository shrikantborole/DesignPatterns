using Prototype;

Console.Title = "Prototype";
Author originalAuthor = new Author()
{
    Name = "Sukesh Marla",
    TwitterAccount = "https://twitter.com/SukeshMarla",
    Website = "http://www.sukesh-marla.com",
    HomeAddress = new Address()
    {
        City = "Mumbai",
        State = "Maharastra"
    }
};
Console.WriteLine("Original Copy");
Console.WriteLine($"{originalAuthor.Name}, {originalAuthor.TwitterAccount}, {originalAuthor.Website}, {originalAuthor.HomeAddress.City}, {originalAuthor.HomeAddress.State}");
Author clonedObject = (Author)originalAuthor.Clone();
Console.WriteLine("\nCloned Copy");
Console.WriteLine($"{clonedObject.Name}, {clonedObject.TwitterAccount}, {clonedObject.Website}, {clonedObject.HomeAddress.City}, {clonedObject.HomeAddress.State}");
Console.WriteLine("\nMake Changes to clone copy address");
clonedObject.Name = "Mr.Changer";
clonedObject.TwitterAccount = "https://twitter.com/MrChanger";
clonedObject.Website = "https://MrChanger.com";
clonedObject.HomeAddress.State = "Karnataka";
clonedObject.HomeAddress.City = "Manglore";
Console.WriteLine("\nCloned Copy");
Console.WriteLine($"{clonedObject.Name}, {clonedObject.TwitterAccount}, {clonedObject.Website}, {clonedObject.HomeAddress.City}, {clonedObject.HomeAddress.State}");
Console.WriteLine("\nOriginal Copy");
Console.WriteLine($"{originalAuthor.Name}, {originalAuthor.TwitterAccount}, {originalAuthor.Website}, {originalAuthor.HomeAddress.City}, {originalAuthor.HomeAddress.State}");
