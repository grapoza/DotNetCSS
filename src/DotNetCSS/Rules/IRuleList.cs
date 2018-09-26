using System.Collections.Generic;

namespace NetCSS
{
    public interface IRuleList : IEnumerable<IRule>
    {
        IRule this[int index] { get; }
        int Length { get; }
    }
}