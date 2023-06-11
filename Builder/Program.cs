using Builder.Fluent;
using Builder.Simple;

Console.Title = "Builder";
//Simple Builder
var simpleBuilder = new SimpleBuilder();
simpleBuilder.CallSimpleBuilder();

//FluentBlogBuilder
FluentBuilder _fluentBuilder = new FluentBuilder();
_fluentBuilder.CallFluentBuilder();