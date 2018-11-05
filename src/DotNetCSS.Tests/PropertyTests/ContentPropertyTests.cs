namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;
    using System;

    //[TestFixture]
    public class ContentPropertyTests
    {
        static StyleRule Parse(string source)
        {
            var parser = new StylesheetParser();
            var rule = parser.Parse(source).Rules[0];
            return rule as StyleRule;
        }

        [Fact]
        public void ContentParseStringWithDoubleQuoteEscape()
        {
            var source = "a{content:\"\\\"\"}";
            var parsed = Parse(source);
            Assert.Equal("\"\\\"\"", parsed.Style.Content);
        }

        [Fact]
        public void ContentParseStringWithSingleQuoteEscape()
        {
            var source = "a{content:'\\''}";
            var parsed = Parse(source);
            Assert.Equal("\"'\"", parsed.Style.Content);
        }

        [Fact]
        public void ContentParseStringWithDoubleQuoteMultipleEscapes()
        {
            var source = "a{content:\"abc\\\"\\\"d\\\"ef\"}";
            var parsed = Parse(source);
            Assert.Equal("\"abc\\\"\\\"d\\\"ef\"", parsed.Style.Content);
        }

        [Fact]
        public void ContentParseStringWithSingleQuoteMultipleEscapes()
        {
            var source = "a{content:'abc\\'\\'d\\'ef'}";
            var parsed = Parse(source);
            Assert.Equal("\"abc''d'ef\"", parsed.Style.Content);
        }
    }
}
