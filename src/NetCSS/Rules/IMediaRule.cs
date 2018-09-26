
namespace NetCSS
{
    public interface IMediaRule : IConditionRule
    {
        MediaList Media { get; }
    }
}