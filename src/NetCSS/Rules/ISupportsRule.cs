namespace NetCSS
{
    public interface ISupportsRule : IConditionRule
    {
        IConditionFunction Condition { get; }
    }
}