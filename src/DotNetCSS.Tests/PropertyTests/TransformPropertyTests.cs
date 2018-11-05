namespace DotNetCSS.Tests
{
    using DotNetCSS;
    using Xunit;

    //[TestFixture]
    public class TransformPropertyTests : CssConstructionFunctions
    {
        [Fact]
        public void PerspectiveNoneUppercaseLegal()
        {
            var snippet = "perspective:  NONE ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveProperty>(property);
            var concrete = (PerspectiveProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void PerspectiveLengthPixelLegal()
        {
            var snippet = "perspective:  20px  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveProperty>(property);
            var concrete = (PerspectiveProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("20px", concrete.Value);
        }

        [Fact]
        public void PerspectiveLengthEmLegal()
        {
            var snippet = "perspective:  3.5em  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveProperty>(property);
            var concrete = (PerspectiveProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3.5em", concrete.Value);
        }

        [Fact]
        public void PerspectiveZeroLegal()
        {
            var snippet = "perspective:  0  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveProperty>(property);
            var concrete = (PerspectiveProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void PerspectivePercentIllegal()
        {
            var snippet = "perspective:  10%  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveProperty>(property);
            var concrete = (PerspectiveProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void PerspectiveOriginZeroLegal()
        {
            var snippet = "perspective-origin:  0  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("0", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginLengthLegal()
        {
            var snippet = "perspective-origin:  20px  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("20px", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginLeftLegal()
        {
            var snippet = "perspective-origin:  left  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("left", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginPercentLegal()
        {
            var snippet = "perspective-origin:  15%  ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("15%", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginPercentPercentLegal()
        {
            var snippet = "perspective-origin:  15% 25% ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("15% 25%", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginLeftCenterLegal()
        {
            var snippet = "perspective-origin:  left center ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("left center", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginRightBottomLegal()
        {
            var snippet = "perspective-origin:  right BOTTOM ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("right bottom", concrete.Value);
        }

        [Fact]
        public void PerspectiveOriginTopCenterLegal()
        {
            var snippet = "perspective-origin:  top center ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("perspective-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<PerspectiveOriginProperty>(property);
            var concrete = (PerspectiveOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("center top", concrete.Value);
        }

        [Fact]
        public void TransformStylePreserve3DLegal()
        {
            var snippet = "transform-style:  preserve-3d ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-style", property.Name);
            Assert.True(property.HasValue);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformStyleProperty>(property);
            var concrete = (TransformStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("preserve-3d", concrete.Value);
        }

        [Fact]
        public void TransformStyleNoneIllegal()
        {
            var snippet = "transform-style:  none ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-style", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformStyleProperty>(property);
            var concrete = (TransformStyleProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.False(concrete.HasValue);
        }

        [Fact]
        public void TransformOriginXOffsetLegal()
        {
            var snippet = "transform-origin:  2px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2px", concrete.Value);
        }

        [Fact]
        public void TransformOriginXOffsetKeywordLegal()
        {
            var snippet = "transform-origin:  bottom ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("bottom", concrete.Value);
        }

        [Fact]
        public void TransformOriginYOffsetLegal()
        {
            var snippet = "transform-origin:  3cm 2px";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("3cm 2px", concrete.Value);
        }

        [Fact]
        public void TransformOriginYOffsetXKeywordLegal()
        {
            var snippet = "transform-origin:  2px left";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2px left", concrete.Value);
        }

        [Fact]
        public void TransformOriginXKeywordYOffsetLegal()
        {
            var snippet = "transform-origin:  left 2px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("left 2px", concrete.Value);
        }

        [Fact]
        public void TransformOriginXKeywordYKeywordLegal()
        {
            var snippet = "transform-origin:  right top ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("right top", concrete.Value);
        }

        [Fact]
        public void TransformOriginYKeywordXKeywordLegal()
        {
            var snippet = "transform-origin:  top  right ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("right top", concrete.Value);
        }

        [Fact]
        public void TransformOriginXYZLegal()
        {
            var snippet = "transform-origin:  2px 30% 10px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2px 30% 10px", concrete.Value);
        }

        [Fact]
        public void TransformOriginYXKeywordZLegal()
        {
            var snippet = "transform-origin:  2px left 10px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("2px left 10px", concrete.Value);
        }

        [Fact]
        public void TransformOriginXKeywordYZLegal()
        {
            var snippet = "transform-origin:  left 5px -3px ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("left 5px -3px", concrete.Value);
        }

        [Fact]
        public void TransformOriginXKeywordYKeywordZLegal()
        {
            var snippet = "transform-origin:  right bottom 2cm ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("right bottom 2cm", concrete.Value);
        }

        [Fact]
        public void TransformOriginYKeywordXKeywordZLegal()
        {
            var snippet = "transform-origin:  bottom  right  2cm ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform-origin", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformOriginProperty>(property);
            var concrete = (TransformOriginProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("right bottom 2cm", concrete.Value);
        }

        [Fact]
        public void TransformNoneLegal()
        {
            var snippet = "transform:  none ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("none", concrete.Value);
        }

        [Fact]
        public void TransformMatrixLegal()
        {
            var snippet = "transform:  matrix(1.0, 2.0, 3.0, 4.0, 5.0, 6.0) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("matrix(1, 2, 3, 4, 5, 6)", concrete.Value);
        }

        [Fact]
        public void TransformTranslateLegal()
        {
            var snippet = "transform:  translate(12px, 50%) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("translate(12px, 50%)", concrete.Value);
        }

        [Fact]
        public void TransformTranslateXLegal()
        {
            var snippet = "transform:  translateX(2em) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("translateX(2em)", concrete.Value);
        }

        [Fact]
        public void TransformTranslateYLegal()
        {
            var snippet = "transform:  translateY(3in) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("translateY(3in)", concrete.Value);
        }

        [Fact]
        public void TransformScaleLegal()
        {
            var snippet = "transform:  scale(2, 0.5) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("scale(2, 0.5)", concrete.Value);
        }

        [Fact]
        public void TransformScaleXLegal()
        {
            var snippet = "transform:  scaleX(0.1) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("scaleX(0.1)", concrete.Value);
        }

        [Fact]
        public void TransformScaleYLegal()
        {
            var snippet = "transform:  scaleY(1.5) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("scaleY(1.5)", concrete.Value);
        }

        [Fact]
        public void TransformRotateLegal()
        {
            var snippet = "transform:  rotate(0.5turn) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("rotate(0.5turn)", concrete.Value);
        }

        [Fact]
        public void TransformSkewXLegal()
        {
            var snippet = "transform:  skewX(  30deg  ) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("skewX(30deg)", concrete.Value);
        }

        [Fact]
        public void TransformSkewYLegal()
        {
            var snippet = "transform:  skewY(  1.07rad  ) ";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("skewY(1.07rad)", concrete.Value);
        }

        [Fact]
        public void TransformMultipleLegal()
        {
            var snippet = "transform:  translate(50%, 50%) rotate(45deg) scale(1.5)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            Assert.Equal("translate(50%, 50%) rotate(45deg) scale(1.5)", concrete.Value);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(3, elements.Length);
        }

        [Fact]
        public void TransformMatrix3dLegal()
        {
            var snippet = "transform:  matrix3d(1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0, 13.0, 14.0, 15.0, 16.0)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<MatrixTransform>(element);
        }

        [Fact]
        public void TransformTranslate3dLegal()
        {
            var snippet = "transform:  translate3d(12px, 50%, 3em)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<TranslateTransform>(element);
        }

        [Fact]
        public void TransformTranslateZLegal()
        {
            var snippet = "transform:  translateZ(2px)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<TranslateTransform>(element);
        }

        [Fact]
        public void TransformScale3dLegal()
        {
            var snippet = "transform:  scale3d(2.5, 1.2, 0.3)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<ScaleTransform>(element);
        }

        [Fact]
        public void TransformScaleZLegal()
        {
            var snippet = "transform:  scaleZ(0.3)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<ScaleTransform>(element);
        }

        [Fact]
        public void TransformRotate3dLegal()
        {
            var snippet = "transform:  rotate3d(1, 2.0, 3.0, 10deg)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<RotateTransform>(element);
        }

        [Fact]
        public void TransformRotateXLegal()
        {
            var snippet = "transform:  rotateX(10deg)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<RotateTransform>(element);
        }

        [Fact]
        public void TransformRotateYLegal()
        {
            var snippet = "transform:  rotateY(10deg)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<RotateTransform>(element);
        }

        [Fact]
        public void TransformRotateZLegal()
        {
            var snippet = "transform: rotateZ(10deg)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<RotateTransform>(element);
        }

        [Fact]
        public void TransformPerspectiveLegal()
        {
            var snippet = "transform: perspective(17px)";
            var property = ParseDeclaration(snippet);
            Assert.Equal("transform", property.Name);
            Assert.False(property.IsImportant);
            Assert.IsType<TransformProperty>(property);
            var concrete = (TransformProperty)property;
            Assert.False(concrete.IsInherited);
            Assert.True(concrete.HasValue);
            //var elements = concrete.Transforms.ToArray();
            //Assert.Equal(1, elements.Length);
            //var element = elements[0];
            //Assert.IsType<PerspectiveTransform>(element);
        }
    }
}
