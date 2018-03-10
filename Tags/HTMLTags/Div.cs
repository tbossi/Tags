using System;
using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Div : Tag
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        public Div() : base("div") { }
    }
}