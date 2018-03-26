using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Time : Tag, SupportDatetimeAttribute
    {
        private DateTime _datetime;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (_datetime != null) { tag.MergeAttribute("datetime", _datetime.ToString("u")); }

                return tag;
            }
        }

        public Time() : base("time") { }

        public void AddDatetime(DateTime datetime)
        {
            _datetime = datetime;
        }
    }
}