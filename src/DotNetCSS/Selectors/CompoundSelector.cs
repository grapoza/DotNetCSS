using System.IO;

namespace DotNetCSS
{
    internal sealed class CompoundSelector : Selectors, ISelector
    {
        public override void ToCss(TextWriter writer, IStyleFormatter formatter)
        {
            foreach (ISelector selector in _selectors)
            {
                writer.Write(selector.Text);
            }
        }
    }
}