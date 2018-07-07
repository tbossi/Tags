using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Form : Tag, SupportAutocompleteAttribute, SupportNameAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Form() : base("form") { }

        public virtual void AddMethod(Method method, EncType? enctype = null)
        {
            TagBuilder.MergeAttribute("method", method.LiteralValue());
            if (method == Method.POST && enctype.HasValue)
            {
                TagBuilder.MergeAttribute("enctype", enctype.Value.LiteralValue());
            }
        }

        public virtual void AddAcceptCharset(Charset charset)
        {
            TagBuilder.MergeAttribute("accept-charset", charset.LiteralValue());
        }

        public virtual void AddAction(string action)
        {
            TagBuilder.MergeAttribute("action", action);
        }

        public virtual void AddNoValidate()
        {
            TagBuilder.MergeAttribute("novalidate", "novalidate");
        }
    }
}