using ChainOfResponsibility;

Console.Title = "Chain of Responsibility";

Document _validDocument = new Document("Name","Title","ApprovedBy");
Document _inValidDocument = new Document(null, "Title", "ApprovedBy");

var _documentHandlerChain = new DocumentTitleHandler();
_documentHandlerChain.SetSuccessor(new DocumentNameHandler())
                    .SetSuccessor(new ApprovedByHandler());

try
{
    _documentHandlerChain.Handle(_validDocument);
    Console.WriteLine("Valid document is valid.");
    _documentHandlerChain.Handle(_inValidDocument);
    Console.WriteLine("Invalid document is valid.");
}
catch (Exception ex)
{
    Console.WriteLine($"Exception occured {ex.Message}");
}