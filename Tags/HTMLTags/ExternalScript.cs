using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class ExternalScript : Script, SupportCharsetAttribute
    {
        public ExternalScript(string src) : base()
        {
            if (string.IsNullOrWhiteSpace(src)) { throw new ArgumentException(); }
            TagBuilder.MergeAttribute("src", src);
        }

        public void AddExecution(Execution execution)
        {
            switch (execution)
            {
                case Execution.Async:
                    TagBuilder.MergeAttribute("async", "async");
                    break;
                case Execution.Defer:
                    TagBuilder.MergeAttribute("defer", "defer");
                    break;
            }
        }
    }
}