using System;
using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Del : Tag, SupportCiteAttribute, SupportDatetimeAttribute
    {
        private string _cite;
        private DateTime _datetime;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;
        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (!string.IsNullOrEmpty(_cite)) { tag.MergeAttribute("cite", _cite); }
                if (_datetime != null) { tag.MergeAttribute("datetime", _datetime.ToString("u")); }

                return tag;
            }
        }

        public Del() : base("del") { }

        public void AddCite(string cite)
        {
            _cite = cite;
        }

        public void AddDatetime(DateTime datetime)
        {
            _datetime = datetime;
        }
    }
}