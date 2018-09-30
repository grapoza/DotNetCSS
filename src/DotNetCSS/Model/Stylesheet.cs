using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotNetCSS
{
    public sealed class Stylesheet : StylesheetNode
    {
        private readonly StylesheetParser _parser;

        internal Stylesheet(StylesheetParser parser)
        {
            _parser = parser;
            Rules = new RuleList(this);
        }

        internal RuleList Rules { get; }

        public IEnumerable<ICharsetRule> CharacterSetRules => Rules.OfType<CharsetRule>();
        public IEnumerable<IFontFaceRule> FontfaceSetRules => Rules.OfType<FontFaceRule>();
        public IEnumerable<IMediaRule> MediaRules => Rules.OfType <MediaRule>();
        public IEnumerable<IImportRule> ImportRules => Rules.OfType <ImportRule>();
        public IEnumerable<INamespaceRule> NamespaceRules => Rules.OfType <NamespaceRule>();
        public IEnumerable<IPageRule> PageRules => Rules.OfType <PageRule>();
        public IEnumerable<IStyleRule> StyleRules => Rules.OfType<StyleRule>();

        public IRule Add(RuleType ruleType)
        {
            var rule = _parser.CreateRule(ruleType);
            Rules.Add(rule);
            return rule;
        }

        public void RemoveAt(int index)
        {
            Rules.RemoveAt(index);
        }

        public int Insert(string ruleText, int index)
        {
            var rule = _parser.ParseRule(ruleText);
            rule.Owner = this;
            Rules.Insert(index, rule);

            return index;
        }

        public override void ToCss(TextWriter writer, IStyleFormatter formatter)
        {
            writer.Write(formatter.Sheet(Rules));
        }
    }
}