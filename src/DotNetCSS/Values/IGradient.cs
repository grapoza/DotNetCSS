using System.Collections.Generic;

namespace DotNetCSS
{
    public interface IGradient : IImageSource
    {
        IEnumerable<GradientStop> Stops { get; }
        bool IsRepeating { get; }
    }
}