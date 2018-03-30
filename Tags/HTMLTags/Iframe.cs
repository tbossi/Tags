using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Iframe : Tag, SupportHeightAttribute, SupportWidthAttribute, SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Iframe(string src) : base("iframe")
        {
            TagBuilder.MergeAttribute("src", src);
        }

        public void AddSrcdoc(string srcdoc)
        {
            TagBuilder.MergeAttribute("srcdoc", srcdoc);
        }

        public void AddSandbox(params Sandbox[] sandbox)
        {
            var builder = new StringBuilder();
            foreach (var s in new HashSet<Sandbox>(sandbox))
            {
                builder.Append(s.Value);
                builder.Append(" ");
            }

            TagBuilder.MergeAttribute("sandbox", builder.ToString().Trim());
        }
    }
}