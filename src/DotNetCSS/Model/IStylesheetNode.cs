using System.Collections.Generic;
namespace DotNetCSS
{
    public interface IStylesheetNode : IStyleFormattable
    {
        IEnumerable<IStylesheetNode> Children { get; }
        StylesheetText StylesheetText { get; }
    }
}