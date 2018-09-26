using System.IO;
namespace NetCSS
{
    public interface IStyleFormattable
    {
        void ToCss(TextWriter writer, IStyleFormatter formatter);
    }
}