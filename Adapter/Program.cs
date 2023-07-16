using static Adapter.Implementation;

Console.Title = "Adapter";
// Adpater design pattern is used to convert/typecase one model to other model.
// Suppose, you are calling to the external system, and it's returning you information which is not
// of type that you are using into your code, then you can write a ADAPTER which will convert the 
// external model into your one.

//In below example, we converted the CityFromExternalSystem to City mode, which is getting used into our code.

ICityAdapter cityAdapter = new CityAdapter();
var city = cityAdapter.GetCity();
Console.WriteLine($"City {city.FullName} - {city.Inhabitants}");