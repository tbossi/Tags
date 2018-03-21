using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Table : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Table() : base("table") { }
    }
}