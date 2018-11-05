namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;

    //[TestFixture]
    public class PaddingPropertyTests : CssConstructionFunctions
    {
        [Fact]
        public void PaddingLeftLengthLegal()
        {
            var snippet = "padding-left: 15px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding-left", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingLeftProperty>(property);
            var concrete = (PaddingLeftProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("15px", concrete.Value);
        }

        [Fact]
        public void PaddingRightLengthImportantLegal()
        {
            var snippet = "padding-right: 3em!important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding-right", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<PaddingRightProperty>(property);
            var concrete = (PaddingRightProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3em", concrete.Value);
        }

        [Fact]
        public void PaddingTopPercentLegal()
        {
            var snippet = "padding-top: 4% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding-top", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingTopProperty>(property);
            var concrete = (PaddingTopProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("4%", concrete.Value);
        }

        [Fact]
        public void PaddingBottomZeroLegal()
        {
            var snippet = "padding-bottom: 0 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding-bottom", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingBottomProperty>(property);
            var concrete = (PaddingBottomProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void PaddingAllZeroLegal()
        {
            var snippet = "padding: 0 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void PaddingAllPercentLegal()
        {
            var snippet = "padding: 25% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("25%", concrete.Value);
        }

        [Fact]
        public void PaddingSidesLengthLegal()
        {
            var snippet = "padding: 10px 3em ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("10px 3em", concrete.Value);
        }

        [Fact]
        public void PaddingAutoIllegal()
        {
            var snippet = "padding: auto ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void PaddingThreeValuesLegal()
        {
            var snippet = "padding: 10px 3em 5px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("10px 3em 5px", concrete.Value);
        }

        [Fact]
        public void PaddingAllValuesWithPercentLegal()
        {
            var snippet = "padding: 10px 5% 8px 2% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("10px 5% 8px 2%", concrete.Value);
        }

        [Fact]
        public void PaddingTooManyValuesIllegal()
        {
            var snippet = "padding: 10px 5% 8px 2% 3px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("padding", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PaddingProperty>(property);
            var concrete = (PaddingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void PaddingShouldBeRecombinedCorrectly()
        {
            var snippet = ".centered {padding-bottom: 2em; padding-top: 2.5em; padding-left: 0; padding-right: 0}";
            var expected = ".centered { padding: 2.5em 0 2em }";
            var result = ParseRule(snippet);
            var actual = result.Text;
            Assert.Equal(expected, actual);
        }
    }
}
