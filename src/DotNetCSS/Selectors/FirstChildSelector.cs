namespace NetCSS

{
    internal sealed class FirstChildSelector : ChildSelector
    {
        public FirstChildSelector()
            : base(PseudoClassNames.NthChild)
        {
        }
    }
}