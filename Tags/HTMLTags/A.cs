using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class A : Tag, IRelable, ITargetable
    {
        private readonly string _href;
        private string _newFileName;
        private Rel? _rel;
        private Target? _target;

        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        protected override TagBuilder GeneratedTag
        {
            get
            {
                var tag = base.GeneratedTag;
                if (!string.IsNullOrEmpty(_href)) { tag.MergeAttribute("href", _href); }
                if (_newFileName != null) { tag.MergeAttribute("download", _newFileName); }
                if (_rel.HasValue) { tag.MergeAttribute("rel", _rel.Value.LiteralValue()); }
                if (_target.HasValue) { tag.MergeAttribute("target", _target.Value.LiteralValue()); }

                return tag;
            }
        }

        public A(string href) : base("a")
        {
            _href = href;
        }

        public virtual void AddDownload(string newFileName)
        {
            _newFileName = newFileName;
        }

        public virtual void AddRel(Rel rel)
        {
            _rel = rel;
        }

        public virtual void AddTarget(Target target)
        {
            _target = target;
        }
    }
}