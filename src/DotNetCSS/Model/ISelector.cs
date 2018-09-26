
namespace DotNetCSS
{
    public interface ISelector : IStylesheetNode
    {
        Priority Specifity { get; }
        string Text { get; }
    }
}