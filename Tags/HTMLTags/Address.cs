using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Address : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Address() : base("address") { }
    }
}