namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;

    //[TestFixture]
    public class PropertyTests : CssConstructionFunctions
    {
        [Fact]
        public void BreakAfterLegalAvoid()
        {
            var snippet = "break-after:avoid";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-after", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakAfterProperty>(property);
            var concrete = (BreakAfterProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("avoid", concrete.Value);
        }

        [Fact]
        public void PageBreakAfterLegalAvoid()
        {
            var snippet = "page-break-after:avoid";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-after", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakAfterProperty>(property);
            var concrete = (PageBreakAfterProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("avoid", concrete.Value);
        }

        [Fact]
        public void BreakAfterLegalPageCapital()
        {
            var snippet = "break-after:Page";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-after", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakAfterProperty>(property);
            var concrete = (BreakAfterProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("page", concrete.Value);
        }

        [Fact]
        public void PageBreakAfterIllegalAvoidColumn()
        {
            var snippet = "page-break-after:avoid-column";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-after", property.Name);
            Assert.False(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakAfterProperty>(property);
            var concrete = (PageBreakAfterProperty)property;
            Assert.False(concrete.IsInherited);
        }

        [Fact]
        public void BreakAfterLegalAvoidColumn()
        {
            var snippet = "break-after:avoid-column";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-after", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakAfterProperty>(property);
            var concrete = (BreakAfterProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("avoid-column", concrete.Value);
        }

        [Fact]
        public void BreakBeforeLegalAvoidColumn()
        {
            var snippet = "break-before:AUTO";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-before", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakBeforeProperty>(property);
            var concrete = (BreakBeforeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void PageBreakBeforeLegalAvoid()
        {
            var snippet = "page-break-before:AUTO";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-before", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakBeforeProperty>(property);
            var concrete = (PageBreakBeforeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void PageBreakBeforeLegalLeft()
        {
            var snippet = "page-break-before:left";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-before", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakBeforeProperty>(property);
            var concrete = (PageBreakBeforeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("left", concrete.Value);
        }

        [Fact]
        public void BreakBeforeIllegalValue()
        {
            var snippet = "break-before:whatever";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-before", property.Name);
            Assert.False(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakBeforeProperty>(property);
            var concrete = (BreakBeforeProperty)property;
            Assert.NotNull(concrete);
        }

        [Fact]
        public void BreakInsideIllegalPage()
        {
            var snippet = "break-inside:page";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-inside", property.Name);
            Assert.False(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakInsideProperty>(property);
            var concrete = (BreakInsideProperty)property;
            Assert.NotNull(concrete);
        }

        [Fact]
        public void BreakInsideLegalAvoidRegionUppercase()
        {
            var snippet = "break-inside:avoid-REGION";
            var property = ParseDeclaration(snippet);
            Assert.Equal("break-inside", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<BreakInsideProperty>(property);
            var concrete = (BreakInsideProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("avoid-region", concrete.Value);
        }

        [Fact]
        public void PageBreakInsideLegalAvoid()
        {
            var snippet = "page-break-inside:avoid";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-inside", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakInsideProperty>(property);
            var concrete = (PageBreakInsideProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("avoid", concrete.Value);
        }

        [Fact]
        public void PageBreakInsideLegalAutoUppercase()
        {
            var snippet = "page-break-inside:AUTO";
            var property = ParseDeclaration(snippet);
            Assert.Equal("page-break-inside", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PageBreakInsideProperty>(property);
            var concrete = (PageBreakInsideProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void ClearLegalLeft()
        {
            var snippet = "clear:left";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clear", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<ClearProperty>(property);
            var concrete = (ClearProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("left", concrete.Value);
        }

        [Fact]
        public void ClearLegalBoth()
        {
            var snippet = "clear:both";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clear", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<ClearProperty>(property);
            var concrete = (ClearProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("both", concrete.Value);
        }

        [Fact]
        public void ClearInherited()
        {
            var snippet = "clear:inherit";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clear", property.Name);
            Assert.True(property.HasValue);
            Assert.True(property.IsInherited);
            Assert.False(property.IsImportant);
            Assert.IsType<ClearProperty>(property);
            var concrete = (ClearProperty)property;
            Assert.NotNull(concrete);
        }

        [Fact]
        public void ClearIllegal()
        {
            var snippet = "clear:yes";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clear", property.Name);
            Assert.False(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<ClearProperty>(property);
            var concrete = (ClearProperty)property;
            Assert.NotNull(concrete);
        }

        [Fact]
        public void PositionLegalAbsolute()
        {
            var snippet = "position:absolute";
            var property = ParseDeclaration(snippet);
            Assert.Equal("position", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<PositionProperty>(property);
            var concrete = (PositionProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("absolute", concrete.Value);
        }

        [Fact]
        public void DisplayLegalBlock()
        {
            var snippet = "display:   block ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("display", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<DisplayProperty>(property);
            var concrete = (DisplayProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("block", concrete.Value);
        }

        [Fact]
        public void VisibilityLegalCollapse()
        {
            var snippet = "visibility:collapse";
            var property = ParseDeclaration(snippet);
            Assert.Equal("visibility", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<VisibilityProperty>(property);
            var concrete = (VisibilityProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("collapse", concrete.Value);
        }

        [Fact]
        public void VisibilityLegalHiddenCompleteUppercase()
        {
            var snippet = "VISIBILITY:HIDDEN";
            var property = ParseDeclaration(snippet);
            Assert.Equal("visibility", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<VisibilityProperty>(property);
            var concrete = (VisibilityProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("hidden", concrete.Value);
        }

        [Fact]
        public void OverflowLegalAuto()
        {
            var snippet = "overflow:auto";
            var property = ParseDeclaration(snippet);
            Assert.Equal("overflow", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<OverflowProperty>(property);
            var concrete = (OverflowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void TableLayoutLegalFixedCapitalX()
        {
            var snippet = "table-layout: fiXed";
            var property = ParseDeclaration(snippet);
            Assert.Equal("table-layout", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<TableLayoutProperty>(property);
            var concrete = (TableLayoutProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.Equal("fixed", concrete.Value);
        }

        [Fact]
        public void BoxShadowOffsetLegal()
        {
            var snippet = "box-shadow:  5px 4px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("5px 4px", concrete.Value);
        }

        [Fact]
        public void BoxShadowInsetOffsetLegal()
        {
            var snippet = "box-shadow: inset 5px 4px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inset 5px 4px", concrete.Value);
        }

        [Fact]
        public void BoxShadowNoneUppercaseLegal()
        {
            var snippet = "box-shadow: NONE";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void BoxShadowNormalTealLegal()
        {
            var snippet = "box-shadow: 60px -16px teal";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("60px -16px rgb(0, 128, 128)", concrete.Value);
        }

        [Fact]
        public void BoxShadowNormalSpreadBlackLegal()
        {
            var snippet = "box-shadow: 10px 5px 5px black";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("10px 5px 5px rgb(0, 0, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowOliveAndRedLegal()
        {
            var snippet = "box-shadow: 3px 3px red, -1em 0 0.4em olive";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3px 3px rgb(255, 0, 0), -1em 0 0.4em rgb(128, 128, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowInsetGoldLegal()
        {
            var snippet = "box-shadow: inset 5em 1em gold";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inset 5em 1em rgb(255, 215, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowZeroGoldLegal()
        {
            var snippet = "box-shadow: 0 0 1em gold";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0 0 1em rgb(255, 215, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowInsetZeroGoldLegal()
        {
            var snippet = "box-shadow: inset  0 0 1em gold";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inset 0 0 1em rgb(255, 215, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowInsetZeroGoldAndNormalRedLegal()
        {
            var snippet = "box-shadow: inset  0 0 1em  gold   ,  0 0   1em   red !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inset 0 0 1em rgb(255, 215, 0), 0 0 1em rgb(255, 0, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowOffsetColorLegal()
        {
            var snippet = "box-shadow:  5px 4px #000";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("5px 4px rgb(0, 0, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowOffsetBlurColorLegal()
        {
            var snippet = "box-shadow:  5px 4px 2px #000";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("5px 4px 2px rgb(0, 0, 0)", concrete.Value);
        }

        [Fact]
        public void BoxShadowInitialUppercaseLegal()
        {
            var snippet = "box-shadow:  INITIAL";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("initial", concrete.Value);
        }

        [Fact]
        public void BoxShadowOffsetIllegal()
        {
            var snippet = "box-shadow:  5px 4px 2px 1px 3px #f00";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-shadow", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxShadowProperty>(property);
            var concrete = (BoxShadowProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ClipShapeLegal()
        {
            var snippet = "clip: rect( 2px, 3em, 1in, 0cm )";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rect(2px, 3em, 1in, 0)", concrete.Value);
        }

        [Fact]
        public void ClipShapeBackwards()
        {
            var snippet = "clip: rect( 2px 3em 1in 0cm )";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rect(2px 3em 1in 0)", concrete.Value);
        }

        [Fact]
        public void ClipShapeZerosLegal()
        {
            var snippet = "clip: rect(0, 0, 0, 0)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rect(0, 0, 0, 0)", concrete.Value);
        }

        [Fact]
        public void ClipShapeZerosIllegal()
        {
            var snippet = "clip: rect(0, 0, 0 0)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ClipShapeNonZerosIllegal()
        {
            var snippet = "clip: rect(2px, 1cm, 5mm)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void ClipShapeSingleValueIllegal()
        {
            var snippet = "clip: rect(1em)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("clip", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ClipProperty>(property);
            var concrete = (ClipProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void CursorDefaultUppercaseLegal()
        {
            var snippet = "cursor: DEFAULT";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("default", concrete.Value);
        }

        [Fact]
        public void CursorAutoLegal()
        {
            var snippet = "cursor: auto";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("auto", concrete.Value);
        }

        [Fact]
        public void CursorZoomOutLegal()
        {
            var snippet = "cursor  : zoom-out";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("zoom-out", concrete.Value);
        }

        [Fact]
        public void CursorUrlNoFallbackIllegal()
        {
            var snippet = "cursor  : url(foo.png)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void CursorUrlLegal()
        {
            var snippet = "cursor  : url(foo.png), default";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("url(\"foo.png\"), default", concrete.Value);
        }

        [Fact]
        public void CursorUrlShiftedLegal()
        {
            var snippet = "cursor  : url(foo.png) 0 5, auto";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("url(\"foo.png\") 0 5, auto", concrete.Value);
        }

        [Fact]
        public void CursorUrlShiftedNoFallbackIllegal()
        {
            var snippet = "cursor  : url(foo.png) 0 5";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void CursorUrlsLegal()
        {
            var snippet = "cursor  : url(foo.png), url(master.png), url(more.png), wait";
            var property = ParseDeclaration(snippet);
            Assert.Equal("cursor", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<CursorProperty>(property);
            var concrete = (CursorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("url(\"foo.png\"), url(\"master.png\"), url(\"more.png\"), wait", concrete.Value);
        }

        [Fact]
        public void ColorHexLegal()
        {
            var snippet = "color : #123456";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(18, 52, 86)", concrete.Value);
        }

        [Fact]
        public void ColorRgbLegal()
        {
            var snippet = "color : rgb(121, 181, 201)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(121, 181, 201)", concrete.Value);
        }

        [Fact]
        public void ColorRgbaLegal()
        {
            var snippet = "color : rgba(255, 255, 201, 0.7)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgba(255, 255, 201, 0.7)", concrete.Value);
        }

        [Fact]
        public void ColorNameLegal()
        {
            var snippet = "color : red";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(255, 0, 0)", concrete.Value);
        }

        [Fact]
        public void ColorNameUppercaseLegal()
        {
            var snippet = "color : BLUE";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rgb(0, 0, 255)", concrete.Value);
        }

        [Fact]
        public void ColorNameIllegal()
        {
            var snippet = "color : horse";
            var property = ParseDeclaration(snippet);
            Assert.Equal("color", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ColorProperty>(property);
            var concrete = (ColorProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void OrphansZeroLegal()
        {
            var snippet = "orphans : 0 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("orphans", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<OrphansProperty>(property);
            var concrete = (OrphansProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void OrphansTwoLegal()
        {
            var snippet = "orphans : 2 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("orphans", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<OrphansProperty>(property);
            var concrete = (OrphansProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2", concrete.Value);
        }

        [Fact]
        public void OrphansNegativeIllegal()
        {
            var snippet = "orphans : -2 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("orphans", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<OrphansProperty>(property);
            var concrete = (OrphansProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void OrphansFloatingIllegal()
        {
            var snippet = "orphans : 1.5 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("orphans", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<OrphansProperty>(property);
            var concrete = (OrphansProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void BoxDecorationBreakNumberIllegal()
        {
            var snippet = "box-decoration-break : 1.5 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-decoration-break", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxDecorationBreak>(property);
            var concrete = (BoxDecorationBreak)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void BoxDecorationBreakSliceLegal()
        {
            var snippet = "box-decoration-break : slice ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-decoration-break", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxDecorationBreak>(property);
            var concrete = (BoxDecorationBreak)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("slice", concrete.Value);
        }

        [Fact]
        public void BoxDecorationBreakClonePascalLegal()
        {
            var snippet = "box-decoration-break : Clone ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-decoration-break", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<BoxDecorationBreak>(property);
            var concrete = (BoxDecorationBreak)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("clone", concrete.Value);
        }

        [Fact]
        public void BoxDecorationBreakInheritLegal()
        {
            var snippet = "box-decoration-break : inherit!important ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("box-decoration-break", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<BoxDecorationBreak>(property);
            var concrete = (BoxDecorationBreak)property;
            Assert.True(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("inherit", concrete.Value);
        }

        [Fact]
        public void ContentNormalLegal()
        {
            var snippet = "content : normal ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void ContentNoneLegalUppercaseN()
        {
            var snippet = "content : noNe ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void ContentStringLegal()
        {
            var snippet = "content : 'hi' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("\"hi\"", concrete.Value);
        }

        [Fact]
        public void ContentNoOpenQuoteNoCloseQuoteLegal()
        {
            var snippet = "content : no-open-quote no-close-quote ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("no-open-quote no-close-quote", concrete.Value);
        }

        [Fact]
        public void ContentUrlLegal()
        {
            var snippet = "content : url(test.html) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("url(\"test.html\")", concrete.Value);
        }

        [Fact]
        public void ContentStringsLegal()
        {
            var snippet = "content : 'how' 'are' 'you' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("content", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<ContentProperty>(property);
            var concrete = (ContentProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("\"how\" \"are\" \"you\"", concrete.Value);
        }

        [Fact]
        public void QuoteStringIllegal()
        {
            var snippet = "quotes : '\"' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void QuoteStringsLegal()
        {
            var snippet = "quotes : '\"' '\"' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("\"\\\"\" \"\\\"\"", concrete.Value);
        }

        [Fact]
        public void QuoteStringsIllegal()
        {
            var snippet = "quotes : \"'\"";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void QuoteStringsMultipleLegal()
        {
            var snippet = "quotes : '\"' '\"' '`' '´' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("\"\\\"\" \"\\\"\" \"`\" \"´\"", concrete.Value);
        }

        [Fact]
        public void QuoteStringsMultipleIllegal()
        {
            var snippet = "quotes : '\"' '\"' '`' ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void QuoteNoneLegal()
        {
            var snippet = "quotes : none";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void QuoteNoneStringIllegal()
        {
            var snippet = "quotes : 'none'";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void QuoteNormalIllegal()
        {
            var snippet = "quotes : normal ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("quotes", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<QuotesProperty>(property);
            var concrete = (QuotesProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void WidowsZeroLegal()
        {
            var snippet = "widows: 0";
            var property = ParseDeclaration(snippet);
            Assert.Equal("widows", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<WidowsProperty>(property);
            var concrete = (WidowsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(0, concrete.Count);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void WidowsThreeLegal()
        {
            var snippet = "widows: 3";
            var property = ParseDeclaration(snippet);
            Assert.Equal("widows", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<WidowsProperty>(property);
            var concrete = (WidowsProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(3, concrete.Count);
            Assert.Equal("3", concrete.Value);
        }

        [Fact]
        public void WidowsLengthIllegal()
        {
            var snippet = "widows: 5px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("widows", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<WidowsProperty>(property);
            var concrete = (WidowsProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
            //Assert.Equal(2, concrete.Count);
        }

        [Fact]
        public void UnicodeBidiEmbedLegal()
        {
            var snippet = "unicode-BIDI: Embed";
            var property = ParseDeclaration(snippet);
            Assert.Equal("unicode-bidi", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<UnicodeBidirectionalProperty>(property);
            var concrete = (UnicodeBidirectionalProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(UnicodeMode.Embed, concrete.State);
            Assert.Equal("embed", concrete.Value);
        }

        [Fact]
        public void UnicodeBidiIsolateLegal()
        {
            var snippet = "unicode-Bidi: isolate";
            var property = ParseDeclaration(snippet);
            Assert.Equal("unicode-bidi", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<UnicodeBidirectionalProperty>(property);
            var concrete = (UnicodeBidirectionalProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(UnicodeMode.Isolate, concrete.State);
            Assert.Equal("isolate", concrete.Value);
        }

        [Fact]
        public void UnicodeBidiBidiOverrideLegal()
        {
            var snippet = "unicode-Bidi: Bidi-Override";
            var property = ParseDeclaration(snippet);
            Assert.Equal("unicode-bidi", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<UnicodeBidirectionalProperty>(property);
            var concrete = (UnicodeBidirectionalProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(UnicodeMode.BidiOverride, concrete.State);
            Assert.Equal("bidi-override", concrete.Value);
        }

        [Fact]
        public void UnicodeBidiPlaintextLegal()
        {
            var snippet = "unicode-Bidi: PLAINTEXT";
            var property = ParseDeclaration(snippet);
            Assert.Equal("unicode-bidi", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<UnicodeBidirectionalProperty>(property);
            var concrete = (UnicodeBidirectionalProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //Assert.Equal(UnicodeMode.Plaintext, concrete.State);
            Assert.Equal("plaintext", concrete.Value);
        }

        [Fact]
        public void UnicodeBidiIllegal()
        {
            var snippet = "unicode-bidi: none";
            var property = ParseDeclaration(snippet);
            Assert.Equal("unicode-bidi", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<UnicodeBidirectionalProperty>(property);
            var concrete = (UnicodeBidirectionalProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
            //Assert.Equal(UnicodeMode.Normal, concrete.State);
        }

        [Fact]
        public void PropertyFactoryCalls()
        {
            var parser = new StylesheetParser();
            var decl = new StyleDeclaration(parser);
            var invalid = decl.CreateProperty("invalid");
            var border = decl.CreateProperty("border");
            var color = decl.CreateProperty("color");
            decl.SetProperty(color);
            var colorAgain = decl.CreateProperty("color");

            Assert.Null(invalid);
            Assert.NotNull(border);
            Assert.NotNull(color);
            Assert.NotNull(colorAgain);

            Assert.IsType<BorderProperty>(border);
            Assert.IsType<ColorProperty>(color);
            Assert.Equal(color, colorAgain);
        }

        [Fact]
        public void UnknownPropertyPreservesCase()
        {
            var snippet = "my-Property: something";
            var property = ParseDeclaration(snippet, includeUnknownDeclarations:true);
            Assert.Equal("my-Property", property.Name);
            Assert.IsType<UnknownProperty>(property);
        }
    }
}
