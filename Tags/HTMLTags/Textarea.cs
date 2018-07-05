using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Textarea : Tag, SupportAutofocusAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Textarea() : base("textarea") { }

        public void AddCols(int cols)
        {
            if (cols < 0) { throw new ArgumentException(); }
            TagBuilder.MergeAttribute("cols", cols.ToString());
        }
    }
}