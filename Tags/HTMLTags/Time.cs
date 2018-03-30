using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Time : Tag, SupportDatetimeAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Time() : base("time") { }
    }
}