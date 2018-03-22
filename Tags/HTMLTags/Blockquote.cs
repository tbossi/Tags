using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class Blockquote : Tag
    {
        private readonly string _cite;
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

        public Blockquote(string cite = "") : base("blockquote")
        {
            _cite = cite;
        }
    }
}