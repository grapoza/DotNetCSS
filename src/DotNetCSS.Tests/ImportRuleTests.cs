namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;
    using System;

    //[TestFixture]
    public class ImportRuleTests
    {
        static ImportRule NewImportRule(string cssText)
        {
            var parser = new StylesheetParser();
            var rule = new ImportRule(parser) { Text = cssText };
            return rule;
        }

        [Fact]
        public void ImportWithNonQuotedUrl()
        {
            var source = "@import url(button.css);";
            var rule = NewImportRule(source);
            Assert.Equal("button.css", rule.Href);
            Assert.Equal("", rule.Media.MediaText);
        }

        [Fact]
        public void ImportWithDoubleQuotedUrl()
        {
            var source = "@import url(\"button.css\");";
            var rule = NewImportRule(source);
            Assert.Equal("button.css", rule.Href);
            Assert.Equal("", rule.Media.MediaText);
        }

        [Fact]
        public void ImportWithSingleQuotedUrl()
        {
            var source = "@import url('button.css');";
            var rule = NewImportRule(source);
            Assert.Equal("button.css", rule.Href);
            Assert.Equal("", rule.Media.MediaText);
        }

        [Fact]
        public void ImportWithDoubleQuotedStringAsUrl()
        {
            var source = "@import \"button.css\";";
            var rule = NewImportRule(source);
            Assert.Equal("button.css", rule.Href);
            Assert.Equal("", rule.Media.MediaText);
        }

        [Fact]
        public void ImportWithSingleQuotedStringAsUrl()
        {
            var source = "@import 'button.css';";
            var rule = NewImportRule(source);
            Assert.Equal("button.css", rule.Href);
            Assert.Equal("", rule.Media.MediaText);
        }

        [Fact]
        public void ImportWithUrlAndAllMedia()
        {
            var media = "all";
            var source = "@import url(size/medium.css) " + media + ";";
            var rule = NewImportRule(source);
            Assert.Equal("size/medium.css", rule.Href);
            Assert.Equal(media, rule.Media.MediaText);
            Assert.Equal(1, rule.Media.Length);
        }

        [Fact]
        public void ImportWithUrlAndComplicatedMedia()
        {
            var media = "screen and (color), projection and (min-color: 256)";
            var source = "@import url(old.css) " + media + ";";
            var rule = NewImportRule(source);
            Assert.Equal("old.css", rule.Href);
            Assert.Equal(media, rule.Media.MediaText);
            Assert.Equal(2, rule.Media.Length);
        }
    }
}
