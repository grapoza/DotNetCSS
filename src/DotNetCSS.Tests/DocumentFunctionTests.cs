namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;
    using System.Linq;

    //[TestFixture]
    public class DocumentFunctionTests : CssConstructionFunctions
    {
        [Fact]
        public void DocumentRuleSingleUrlFunction()
        {
            var snippet = "@document url(http://www.w3.org/) { }";
            var rule = ParseRule(snippet) as DocumentRule;
            Assert.NotNull(rule);
            Assert.Equal(RuleType.Document, rule.Type);
            Assert.Single(rule.Conditions);
            var condition = rule.Conditions.First();
            Assert.Equal("url", condition.Name);
            Assert.Equal("http://www.w3.org/", condition.Data);
        }

        [Fact]
        public void DocumentRuleSingleUrlPrefixFunction()
        {
            var snippet = "@document url-prefix(http://www.w3.org/Style/) { }";
            var rule = ParseRule(snippet) as DocumentRule;
            Assert.NotNull(rule);
            Assert.Equal(RuleType.Document, rule.Type);
            Assert.Single(rule.Conditions);
            var condition = rule.Conditions.First();
            Assert.Equal("url-prefix", condition.Name);
            Assert.Equal("http://www.w3.org/Style/", condition.Data);
        }

        [Fact]
        public void DocumentRuleSingleDomainFunction()
        {
            var snippet = "@document domain('mozilla.org') { }";
            var rule = ParseRule(snippet) as DocumentRule;
            Assert.NotNull(rule);
            Assert.Equal(RuleType.Document, rule.Type);
            Assert.Single(rule.Conditions);
            var condition = rule.Conditions.First();
            Assert.Equal("domain", condition.Name);
            Assert.Equal("mozilla.org", condition.Data);
        }

        [Fact]
        public void DocumentRuleSingleRegexpFunction()
        {
            var snippet = "@document regexp(\"https:.*\") { }";
            var rule = ParseRule(snippet) as DocumentRule;
            Assert.NotNull(rule);
            Assert.Equal(RuleType.Document, rule.Type);
            Assert.Single(rule.Conditions);
            var condition = rule.Conditions.First();
            Assert.Equal("regexp", condition.Name);
            Assert.Equal("https:.*", condition.Data);
        }

        [Fact]
        public void DocumentRuleMultipleFunctions()
        {
            var snippet = "@document url(http://www.w3.org/), url-prefix(http://www.w3.org/Style/), domain(mozilla.org), regexp(\"https:.*\") { }";
            var rule = ParseRule(snippet) as DocumentRule;
            Assert.NotNull(rule);
            Assert.Equal(RuleType.Document, rule.Type);
            Assert.Equal(4, rule.Conditions.Count());
        }
    }
}
