using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Textarea : Tag, SupportAutofocusAttribute, SupportDisabledAttribute,
        SupportFormAttribute, SupportMaxLengthAttribute, SupportNameAttribute,
        SupportPlaceholderAttribute, SupportReadonlyAttribute, SupportRequiredAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Textarea() : base("textarea") { }

        public void AddCols(int cols)
        {
            if (cols < 0) { throw new ArgumentException(); }
            AddAttribute("cols", cols.ToString());
        }

        public void AddRows(int rows)
        {
            if (rows < 0) { throw new ArgumentException(); }
            AddAttribute("rows", rows.ToString());
        }

        public void AddWrap(Wrap wrap)
        {
            AddAttribute("wrap", wrap.LiteralValue());
        }
    }
}