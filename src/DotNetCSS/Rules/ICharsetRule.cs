using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCSS
{
    public interface ICharsetRule : IRule
    {
        string CharacterSet { get; set; }
    }
}
