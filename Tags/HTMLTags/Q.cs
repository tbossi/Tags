using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Q : Tag, SupportCiteAttribute
    {
        private string _cite;
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tagToBuild = base.GeneratedTag;
                if (!string.IsNullOrEmpty(_cite)) { tagToBuild.MergeAttribute("cite", _cite); }
                return tagToBuild;
            }
        }

        public Q() : base("q") { }

        public void AddCite(string cite)
        {
            _cite = cite;
        }
    }
}