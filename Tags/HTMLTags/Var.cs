using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Var : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Var() : base("var") { }
    }
}