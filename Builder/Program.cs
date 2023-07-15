using Builder.Child;
using Builder.Fluent;
using Builder.Simple;

Console.Title = "Builder";
//Simple Builder
var simpleBuilder = new SimpleBuilder();
simpleBuilder.CallSimpleBuilder();

//FluentBlogBuilder
FluentBuilder _fluentBuilder = new FluentBuilder();
_fluentBuilder.CallFluentBuilder();

//Child Parent Builder

//Progressive Builder
Builder.Progressive.ProgressiveBuilder progressiveBuilder = new Builder.Progressive.ProgressiveBuilder();
progressiveBuilder.CallProgressiveBuilder();
