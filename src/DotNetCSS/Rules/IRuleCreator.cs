namespace DotNetCSS
{
    public interface IRuleCreator
    {
        IRule AddNewRule(RuleType ruleType);
    }
}