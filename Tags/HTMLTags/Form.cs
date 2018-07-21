using System.Web.Mvc;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Form : Tag, SupportAutocompleteAttribute, SupportNameAttribute,
        SupportTargetAttribute
    {
        public override TagRenderMode TagRenderMode => TagRenderMode.Normal;

        public Form() : base("form") { }

        public virtual void AddMethod(Method method, EncType? enctype = null)
        {
            AddAttribute("method", method.LiteralValue());
            if (method == Method.POST && enctype.HasValue)
            {
                AddAttribute("enctype", enctype.Value.LiteralValue());
            }
        }

        public virtual void AddAcceptCharset(Charset charset)
        {
            AddAttribute("accept-charset", charset.LiteralValue());
        }

        public virtual void AddAction(string action)
        {
            AddAttribute("action", action);
        }

        public virtual void AddNoValidate()
        {
            AddAttribute("novalidate", "novalidate");
        }
    }
}