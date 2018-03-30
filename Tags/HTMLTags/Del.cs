using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Del : Tag, SupportCiteAttribute, SupportDatetimeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Del() : base("del") { }
    }
}