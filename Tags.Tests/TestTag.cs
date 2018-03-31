using System.Web.Mvc;
using Tags.HTMLTags;

namespace Tags.Test
{
    public class TestTag : Tag
    {
        public override TagRenderMode TagRenderMode { get; }
        public TestTag(string name = "testtag", TagRenderMode renderMode = TagRenderMode.Normal)
            : base(name)
        {
            TagRenderMode = renderMode;
        }
    }
}