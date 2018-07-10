using System.Web.Mvc;
using Tags.Exception;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Input : Tag, SupportAltAttribute, SupportAutocompleteAttribute,
        SupportAutofocusAttribute, SupportDisabledAttribute, SupportFormAttribute,
        SupportHeightAttribute, SupportMaxLengthAttribute, SupportMultipleAttribute,
        SupportNameAttribute, SupportPlaceholderAttribute, SupportReadonlyAttribute,
        SupportRequiredAttribute
    {
        private readonly Attributes.InputType _inputType;

        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Input(Attributes.InputType inputType) : base("input")
        {
            _inputType = inputType;
            TagBuilder.MergeAttribute("type", _inputType.LiteralValue());
        }

        public virtual void AddAccept(string fileType)
        {
            TagBuilder.MergeAttribute("accept", fileType);
        }

        public virtual void AddChecked()
        {
            switch (_inputType)
            {
                case Attributes.InputType.Checkbox:
                case Attributes.InputType.Radio:
                    TagBuilder.MergeAttribute("checked", "checked");
                    break;
                default:
                    throw new InvalidAttribute("checked", this);
            }
        }

        public virtual void AddList(string datalistId)
        {
            TagBuilder.MergeAttribute("list", datalistId);
        }

        public virtual void AddPattern(string pattern)
        {
            switch (_inputType)
            {
                case Attributes.InputType.Date:
                case Attributes.InputType.Email:
                case Attributes.InputType.Password:
                case Attributes.InputType.Search:
                case Attributes.InputType.Tel:
                case Attributes.InputType.Text:
                case Attributes.InputType.Url:
                    TagBuilder.MergeAttribute("pattern", pattern);
                    break;
                default:
                    throw new InvalidAttribute("pattern", this);
            }
        }
    }
}