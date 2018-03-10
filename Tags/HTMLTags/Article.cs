using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Article : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Article() : base("article") { }
    }
}