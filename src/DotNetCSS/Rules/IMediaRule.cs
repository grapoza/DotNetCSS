
namespace DotNetCSS
{
    public interface IMediaRule : IConditionRule
    {
        MediaList Media { get; }
    }
}