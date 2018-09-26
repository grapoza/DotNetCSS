
namespace NetCSS
{
    internal sealed class StrokeMiterlimitProperty : Property
    {
        private static readonly IValueConverter StyleConverter = Converters.StrokeMiterlimitConverter;

        public StrokeMiterlimitProperty()
            : base(PropertyNames.StrokeMiterlimit, PropertyFlags.Animatable)
        {
        }

        internal override IValueConverter Converter => StyleConverter;
    }
}