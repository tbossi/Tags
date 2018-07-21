using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Tags.Encoders;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Iframe : Tag, SupportHeightAttribute, SupportWidthAttribute,
        SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Iframe(string src) : base("iframe")
        {
            AddAttribute("src", src);
        }

        public void AddSrcdoc(string srcdoc)
        {
            AddAttribute("srcdoc", srcdoc, new PassThroughEncoder());
        }

        public void AddSandbox(params Sandbox[] sandbox)
        {
            var builder = new StringBuilder();
            foreach (var s in new HashSet<Sandbox>(sandbox))
            {
                builder.Append(s.LiteralValue());
                builder.Append(" ");
            }

            AddAttribute("sandbox", builder.ToString().Trim());
        }
    }
}