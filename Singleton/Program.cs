Console.Title = "Singleton";

var instance1 = Singleton.SingletonDemo.Instance;
var instance2 = Singleton.SingletonDemo.Instance;

// We are able to access it, because we have created single instance, for the lifetime of application.
// Don't confuse with the static method - as it's not static method then alos we are able to access it.
instance1.Logger();

Console.WriteLine($"Both Instance are same: {instance1 == instance2}");
Console.WriteLine("Press key to exit");
