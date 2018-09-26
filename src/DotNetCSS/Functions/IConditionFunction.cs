namespace DotNetCSS
{
    public interface IConditionFunction : IStylesheetNode
    {
        bool Check();
    }
}