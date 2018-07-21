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
            AddAttribute("src", src);
        }

        public void AddExecution(Execution execution)
        {
            switch (execution)
            {
                case Execution.Async:
                    AddAttribute("async", "async");
                    break;
                case Execution.Defer:
                    AddAttribute("defer", "defer");
                    break;
            }
        }
    }
}