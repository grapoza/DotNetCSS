namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;

    //[TestFixture]
    public class FontPropertyTests : CssConstructionFunctions
    {
        [Fact]
        public void FontFamilyMultipleWithIdentifiersLegal()
        {
            var snippet = "font-family: Gill Sans Extrabold, sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("Gill Sans Extrabold, sans-serif", concrete.Value);
        }

        [Fact]
        public void FontFamilyInitialLegal()
        {
            var snippet = "font-family: initial ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("initial", concrete.Value);
        }

        [Fact]
        public void FontFamilyMultipleDiverseLegal()
        {
            var snippet = "font-family: Courier, \"Lucida Console\", monospace ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("Courier, \"Lucida Console\", monospace", concrete.Value);
        }

        [Fact]
        public void FontFamilyMultipleStringLegal()
        {
            var snippet = "font-family: \"Goudy Bookletter 1911\", sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("\"Goudy Bookletter 1911\", sans-serif", concrete.Value);
        }

        [Fact]
        public void FontFamilyMultipleNumberIllegal()
        {
            var snippet = "font-family: Goudy Bookletter 1911, sans-serif  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyMultipleFractionIllegal()
        {
            var snippet = "font-family: Red/Black, sans-serif  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyMultipleStringMixedWithIdentifierIllegal()
        {
            var snippet = "font-family: \"Lucida\" Grande, sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyMultipleExclamationMarkIllegal()
        {
            var snippet = "font-family: Ahem!, sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyMultipleAtIllegal()
        {
            var snippet = "font-family: test@foo, sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyHashIllegal()
        {
            var snippet = "font-family: #POUND ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontFamilyDashIllegal()
        {
            var snippet = "font-family: Hawaii 5-0 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-family", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontFamilyProperty>(property);
            var concrete = (FontFamilyProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontVariantNormalUppercaseLegal()
        {
            var snippet = "font-variant : NORMAL";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-variant", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontVariantProperty>(property);
            var concrete = (FontVariantProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void FontVariantSmallCapsLegal()
        {
            var snippet = "font-variant : small-caps ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-variant", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontVariantProperty>(property);
            var concrete = (FontVariantProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("small-caps", concrete.Value);
        }

        [Fact]
        public void FontVariantSmallCapsIllegal()
        {
            var snippet = "font-variant : smallCaps ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-variant", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontVariantProperty>(property);
            var concrete = (FontVariantProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontStyleItalicLegal()
        {
            var snippet = "font-style : italic";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontStyleProperty>(property);
            var concrete = (FontStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("italic", concrete.Value);
        }

        [Fact]
        public void FontStyleObliqueLegal()
        {
            var snippet = "font-style : oblique ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontStyleProperty>(property);
            var concrete = (FontStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("oblique", concrete.Value);
        }

        [Fact]
        public void FontStyleNormalImportantLegal()
        {
            var snippet = "font-style : normal !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-style", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<FontStyleProperty>(property);
            var concrete = (FontStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void FontSizeAbsoluteImportantXxSmallLegal()
        {
            var snippet = "font-size : xx-small !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("xx-small", concrete.Value);
        }

        [Fact]
        public void FontSizeAbsoluteMediumUppercaseLegal()
        {
            var snippet = "font-size : medium";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("medium", concrete.Value);
        }

        [Fact]
        public void FontSizeAbsoluteLargeImportantLegal()
        {
            var snippet = "font-size : large !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("large", concrete.Value);
        }

        [Fact]
        public void FontSizeRelativeLargerLegal()
        {
            var snippet = "font-size : larger ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("larger", concrete.Value);
        }

        [Fact]
        public void FontSizeRelativeLargestIllegal()
        {
            var snippet = "font-size : largest ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontSizePercentLegal()
        {
            var snippet = "font-size : 120% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("120%", concrete.Value);
        }

        [Fact]
        public void FontSizeZeroLegal()
        {
            var snippet = "font-size : 0 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void FontSizeLengthLegal()
        {
            var snippet = "font-size : 3.5em ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3.5em", concrete.Value);
        }

        [Fact]
        public void FontSizeNumberIllegal()
        {
            var snippet = "font-size : 120.3 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeProperty>(property);
            var concrete = (FontSizeProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontWeightPercentllegal()
        {
            var snippet = "font-weight : 100% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-weight", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontWeightProperty>(property);
            var concrete = (FontWeightProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontWeightBolderLegalImportant()
        {
            var snippet = "font-weight : bolder !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-weight", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<FontWeightProperty>(property);
            var concrete = (FontWeightProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("bolder", concrete.Value);
        }

        [Fact]
        public void FontWeightBoldLegal()
        {
            var snippet = "font-weight : bold";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-weight", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontWeightProperty>(property);
            var concrete = (FontWeightProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("bold", concrete.Value);
        }

        [Fact]
        public void FontWeight400Legal()
        {
            var snippet = "font-weight : 400 ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-weight", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontWeightProperty>(property);
            var concrete = (FontWeightProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("400", concrete.Value);
        }

        [Fact]
        public void FontStretchNormalUppercaseImportantLegal()
        {
            var snippet = "font-stretch : NORMAL !important";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-stretch", property.Name);
            Assert.True(property.IsImportant);
            Assert.IsType<FontStretchProperty>(property);
            var concrete = (FontStretchProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void FontStretchExtraCondensedLegal()
        {
            var snippet = "font-stretch : extra-condensed ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-stretch", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontStretchProperty>(property);
            var concrete = (FontStretchProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("extra-condensed", concrete.Value);
        }

        [Fact]
        public void FontStretchSemiExpandedSpaceBetweenIllegal()
        {
            var snippet = "font-stretch : semi expanded ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-stretch", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontStretchProperty>(property);
            var concrete = (FontStretchProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontShorthandWithFractionLegal()
        {
            var snippet = "font : 12px/14px sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("12px / 14px sans-serif", concrete.Value);
        }

        [Fact]
        public void FontShorthandPercentLegal()
        {
            var snippet = "font : 80% sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("80% sans-serif", concrete.Value);
        }

        [Fact]
        public void FontShorthandBoldItalicLargeLegal()
        {
            var snippet = "font : bold italic large serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("italic bold large serif", concrete.Value);
        }

        [Fact]
        public void FontShorthandPredefinedLegal()
        {
            var snippet = "font : status-bar ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("status-bar", concrete.Value);
        }

        [Fact]
        public void FontShorthandSizeAndFontListLegal()
        {
            var snippet = "font : 15px arial,sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("15px arial, sans-serif", concrete.Value);
        }

        [Fact]
        public void FontShorthandStyleWeightSizeLineHeightAndFontListLegal()
        {
            var snippet = "font : italic bold 12px/30px Georgia, serif";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("italic bold 12px / 30px Georgia, serif", concrete.Value);
        }

        [Fact]
        public void LetterSpacingLengthPxLegal()
        {
            var snippet = "letter-spacing: 3px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("letter-spacing", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<LetterSpacingProperty>(property);
            var concrete = (LetterSpacingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3px", concrete.Value);
        }

        [Fact]
        public void LetterSpacingLengthFloatPxLegal()
        {
            var snippet = "letter-spacing: .3px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("letter-spacing", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<LetterSpacingProperty>(property);
            var concrete = (LetterSpacingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0.3px", concrete.Value);
        }

        [Fact]
        public void LetterSpacingLengthFloatEmLegal()
        {
            var snippet = "letter-spacing: 0.3em ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("letter-spacing", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<LetterSpacingProperty>(property);
            var concrete = (LetterSpacingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0.3em", concrete.Value);
        }

        [Fact]
        public void LetterSpacingNormalLegal()
        {
            var snippet = "letter-spacing: normal ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("letter-spacing", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<LetterSpacingProperty>(property);
            var concrete = (LetterSpacingProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal", concrete.Value);
        }

        [Fact]
        public void FontSizeAdjustNoneLegal()
        {
            var snippet = "font-size-adjust : NONE";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size-adjust", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeAdjustProperty>(property);
            var concrete = (FontSizeAdjustProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void FontSizeAdjustNumberLegal()
        {
            var snippet = "font-size-adjust : 0.5";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size-adjust", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeAdjustProperty>(property);
            var concrete = (FontSizeAdjustProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0.5", concrete.Value);
        }

        [Fact]
        public void FontSizeAdjustLengthIllegal()
        {
            var snippet = "font-size-adjust : 1.1em ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font-size-adjust", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontSizeAdjustProperty>(property);
            var concrete = (FontSizeAdjustProperty)property;
            Assert.True(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void FontSizeHeightFamilyLegal()
        {
            var snippet = "font: 12pt/14pt sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("12pt / 14pt sans-serif", concrete.Value);
        }

        [Fact]
        public void FontSizeFamilyLegal()
        {
            var snippet = "font: 80% sans-serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("80% sans-serif", concrete.Value);
        }

        [Fact]
        public void FontSizeHeightMultipleFamiliesLegal()
        {
            var snippet = "font: x-large/110% 'New Century Schoolbook', serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("x-large / 110% \"New Century Schoolbook\", serif", concrete.Value);
        }

        [Fact]
        public void FontWeightVariantSizeFamiliesLegal()
        {
            var snippet = "font: bold italic large Palatino, serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("italic bold large Palatino, serif", concrete.Value);
        }

        [Fact]
        public void FontStyleVariantSizeHeightFamilyLegal()
        {
            var snippet = "font: normal small-caps 120%/120% Fantasy ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("normal small-caps 120% / 120% fantasy", concrete.Value);
        }

        [Fact]
        public void FontStyleVariantSizeFamiliesLegal()
        {
            var snippet = "font: condensed oblique 12pt \"Helvetica Neue\", serif ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("oblique condensed 12pt \"Helvetica Neue\", serif", concrete.Value);
        }

        [Fact]
        public void FontSystemFamilyLegal()
        {
            var snippet = "font: status-bar ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("status-bar", concrete.Value);
        }

        [Fact]
        public void FontFaceWithThreeRulesShouldSerializeCorrectly()
        {
            var snippet = @"@font-face {
        font-family: FrutigerLTStd;
            src: url(""https://example.com/FrutigerLTStd-Light.otf"") format(""opentype"");
           font-weight: bold;
    }";
            var rule = ParseRule(snippet);
            Assert.Equal(RuleType.FontFace, rule.Type);
            Assert.Equal("@font-face { font-family: FrutigerLTStd; src: url(\"https://example.com/FrutigerLTStd-Light.otf\") format(\"opentype\"); font-weight: bold }", rule.ToCss());
        }

        [Fact]
        public void FontFaceWithTwoRulesShouldSerializeCorrectly()
        {
            var snippet = @"@font-face {
        font-family: FrutigerLTStd;
            src: url(""https://example.com/FrutigerLTStd-Light.otf"") format(""opentype"");
    }";
            var rule = ParseRule(snippet);
            Assert.Equal(RuleType.FontFace, rule.Type);
            Assert.Equal("@font-face { font-family: FrutigerLTStd; src: url(\"https://example.com/FrutigerLTStd-Light.otf\") format(\"opentype\") }", rule.ToCss());
        }

        [Fact]
        public void FontFaceWithOneRuleShouldSerializeCorrectly()
        {
            var snippet = @"@font-face {
        font-family: FrutigerLTStd;
    }";
            var rule = ParseRule(snippet);
            Assert.Equal(RuleType.FontFace, rule.Type);
            Assert.Equal("@font-face { font-family: FrutigerLTStd }", rule.ToCss());
        }

        [Fact]
        public void FontStyleWeightSizeHeightFamiliesLegal()
        {
            var snippet = "font: italic bold 12px/30px Georgia, serif";
            var property = ParseDeclaration(snippet);
            Assert.Equal("font", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<FontProperty>(property);
            var concrete = (FontProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("italic bold 12px / 30px Georgia, serif", concrete.Value);
            //Assert.Equal(new Length(30f, Length.Unit.Px), concrete.Height);
            //Assert.Equal(new Length(12f, Length.Unit.Px), concrete.Size);
            //Assert.Equal(FontStyle.Italic, concrete.Style);
            //Assert.Equal(2, concrete.Families.Count());
            //Assert.Equal("georgia", concrete.Families.First());
            //Assert.Equal("Times New Roman", concrete.Families.Skip(1).First());
        }
    }
}
