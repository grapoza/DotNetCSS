namespace NetCSS
{
    public interface IConditionFunction : IStylesheetNode
    {
        bool Check();
    }
}