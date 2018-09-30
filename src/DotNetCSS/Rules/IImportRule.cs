using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCSS
{
    public interface IImportRule : IRule
    {
        string Href { get; set; }
        MediaList Media { get; }
        Stylesheet Sheet { get; }
    }
}
