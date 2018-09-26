
namespace NetCSS
{
    internal sealed class LastChildSelector : ChildSelector
    {
        public LastChildSelector()
            : base(PseudoClassNames.NthLastChild)
        {
        }
    }
}