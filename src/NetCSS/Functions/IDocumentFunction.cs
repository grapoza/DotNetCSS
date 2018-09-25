namespace NetCSS
{
    public interface IDocumentFunction : IStylesheetNode
    {
        string Name { get; }
        string Data { get; }
    }
}