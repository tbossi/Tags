using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Fieldset : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Fieldset() : base("fieldset") { }
    }
}