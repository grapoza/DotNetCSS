namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;

    //[TestFixture]
    public class ColumnsPropertyTests : CssConstructionFunctions
    {
        [Fact]
        public void ColumnWidthLengthLegal()
        {
            var snippet = "column-width: 300px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnWidthProperty>(property);
            var concrete = (ColumnWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("300px", concrete.Value);
        }

        [Fact]
        public void ColumnWidthPercentIllegal()
        {
            var snippet = "column-width: 30%";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnWidthProperty>(property);
            var concrete = (ColumnWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnWidthVwLegal()
        {
            var snippet = "column-width: 0.3vw";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnWidthProperty>(property);
            var concrete = (ColumnWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0.3vw", concrete.Value);
        }

        [Fact]
        public void ColumnWidthAutoUppercaseLegal()
        {
            var snippet = "column-width: AUTO";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnWidthProperty>(property);
            var concrete = (ColumnWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void ColumnCountAutoLowercaseLegal()
        {
            var snippet = "column-count: auto";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-count", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnCountProperty>(property);
            var concrete = (ColumnCountProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void ColumnCountNumberLegal()
        {
            var snippet = "column-count: 3";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-count", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnCountProperty>(property);
            var concrete = (ColumnCountProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3", concrete.Value);
        }

        [Fact]
        public void ColumnCountZeroLegal()
        {
            var snippet = "column-count: 0";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-count", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnCountProperty>(property);
            var concrete = (ColumnCountProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void ColumnsZeroLegal()
        {
            var snippet = "columns: 0";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void ColumnsLengthLegal()
        {
            var snippet = "columns: 10px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("10px", concrete.Value);
        }

        [Fact]
        public void ColumnsNumberLegal()
        {
            var snippet = "columns: 4";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("4", concrete.Value);
        }

        [Fact]
        public void ColumnsLengthNumberLegal()
        {
            var snippet = "columns: 25em 5";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("25em 5", concrete.Value);
        }

        [Fact]
        public void ColumnsNumberLengthLegal()
        {
            var snippet = "columns : 5   25em  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("25em 5", concrete.Value);
        }

        [Fact]
        public void ColumnsAutoAutoLegal()
        {
            var snippet = "columns : auto auto";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto auto", concrete.Value);
        }

        [Fact]
        public void ColumnsAutoLegal()
        {
            var snippet = "columns : auto  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void ColumnsNumberPercenIllegal()
        {
            var snippet = "columns : 5   25%  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("columns", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnsProperty>(property);
            var concrete = (ColumnsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnSpanAllLegal()
        {
            var snippet = "column-span: all";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-span", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnSpanProperty>(property);
            var concrete = (ColumnSpanProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("all", concrete.Value);
        }

        [Fact]
        public void ColumnSpanNoneUppercaseLegal()
        {
            var snippet = "column-span: None";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-span", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnSpanProperty>(property);
            var concrete = (ColumnSpanProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void ColumnSpanLengthIllegal()
        {
            var snippet = "column-span: 10px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-span", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnSpanProperty>(property);
            var concrete = (ColumnSpanProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnGapLengthLegal()
        {
            var snippet = "column-gap: 20px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-gap", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnGapProperty>(property);
            var concrete = (ColumnGapProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("20px", concrete.Value);
        }

        [Fact]
        public void ColumnGapNormalLegal()
        {
            var snippet = "column-gap: normal";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-gap", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnGapProperty>(property);
            var concrete = (ColumnGapProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void ColumnGapZeroLegal()
        {
            var snippet = "column-gap: 0";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-gap", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnGapProperty>(property);
            var concrete = (ColumnGapProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void ColumnGapPercentIllegal()
        {
            var snippet = "column-gap: 20%";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-gap", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnGapProperty>(property);
            var concrete = (ColumnGapProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnFillBalanceLegal()
        {
            var snippet = "column-fill: balance;";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-fill", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnFillProperty>(property);
            var concrete = (ColumnFillProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("balance", concrete.Value);
        }

        [Fact]
        public void ColumnFillAutoLegal()
        {
            var snippet = "column-fill: auto;";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-fill", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnFillProperty>(property);
            var concrete = (ColumnFillProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void ColumnRuleColorTransparentLegal()
        {
            var snippet = "column-rule-color: transparent";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleColorProperty>(property);
            var concrete = (ColumnRuleColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgba(0, 0, 0, 0)", concrete.Value);
        }

        [Fact]
        public void ColumnRuleColorRgbLegal()
        {
            var snippet = "column-rule-color: rgb(192, 56, 78)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleColorProperty>(property);
            var concrete = (ColumnRuleColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(192, 56, 78)", concrete.Value);
        }

        [Fact]
        public void ColumnRuleColorRedLegal()
        {
            var snippet = "column-rule-color: red";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleColorProperty>(property);
            var concrete = (ColumnRuleColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(255, 0, 0)", concrete.Value);
        }

        [Fact]
        public void ColumnRuleColorNoneIllegal()
        {
            var snippet = "column-rule-color: none";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleColorProperty>(property);
            var concrete = (ColumnRuleColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnRuleStyleInsetTailUpperLegal()
        {
            var snippet = "column-rule-style: inSET";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleStyleProperty>(property);
            var concrete = (ColumnRuleStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inset", concrete.Value);
        }

        [Fact]
        public void ColumnRuleStyleNoneLegal()
        {
            var snippet = "column-rule-style: none";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleStyleProperty>(property);
            var concrete = (ColumnRuleStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void ColumnRuleStyleAutoIllegal()
        {
            var snippet = "column-rule-style: auto ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleStyleProperty>(property);
            var concrete = (ColumnRuleStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ColumnRuleWidthLengthLegal()
        {
            var snippet = "column-rule-width: 2px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleWidthProperty>(property);
            var concrete = (ColumnRuleWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2px", concrete.Value);
        }

        [Fact]
        public void ColumnRuleWidthThickLegal()
        {
            var snippet = "column-rule-width: thick";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleWidthProperty>(property);
            var concrete = (ColumnRuleWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("5px", concrete.Value);
        }

        [Fact]
        public void ColumnRuleWidthMediumLegal()
        {
            var snippet = "column-rule-width : medium !important ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-width", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<ColumnRuleWidthProperty>(property);
            var concrete = (ColumnRuleWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3px", concrete.Value);
        }

        [Fact]
        public void ColumnRuleWidthThinUppercaseLegal()
        {
            var snippet = "column-rule-width: THIN";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule-width", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleWidthProperty>(property);
            var concrete = (ColumnRuleWidthProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("1px", concrete.Value);
        }

        [Fact]
        public void ColumnRuleDottedLegal()
        {
            var snippet = "column-rule: dotted";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleProperty>(property);
            var concrete = (ColumnRuleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("dotted", concrete.Value);
        }

        [Fact]
        public void ColumnRuleSolidBlueLegal()
        {
            var snippet = "column-rule: solid  blue";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleProperty>(property);
            var concrete = (ColumnRuleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(0, 0, 255) solid", concrete.Value);
        }

        [Fact]
        public void ColumnRuleSolidLengthLegal()
        {
            var snippet = "column-rule: solid 8px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleProperty>(property);
            var concrete = (ColumnRuleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("8px solid", concrete.Value);
        }

        [Fact]
        public void ColumnRuleThickInsetBlueLegal()
        {
            var snippet = "column-rule: thick inset blue";
            var property = ParseDeclaration(snippet);
            Assert.Equal("column-rule", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColumnRuleProperty>(property);
            var concrete = (ColumnRuleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(0, 0, 255) 5px inset", concrete.Value);
        }
    }
}
