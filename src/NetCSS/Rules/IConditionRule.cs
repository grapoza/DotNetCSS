namespace NetCSS
{
    public interface IConditionRule : IGroupingRule
    {
        string ConditionText { get; set; }
    }
}