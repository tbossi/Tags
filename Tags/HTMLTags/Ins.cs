using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Ins : Tag, SupportCiteAttribute, SupportDatetimeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Ins() : base("ins") { }
    }
}