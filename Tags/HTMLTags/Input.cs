using System.Web.Mvc;
using Tags.Exception;
using Tags.HTMLTags.Attributes;

namespace Tags.HTMLTags
{
    public class Input : Tag, SupportAltAttribute, SupportAutocompleteAttribute, SupportAutofocusAttribute
    {
        private readonly Attributes.InputType _inputType;

        public override TagRenderMode TagRenderMode => TagRenderMode.StartTag;

        public Input(Attributes.InputType inputType) : base("input")
        {
            _inputType = inputType;
            TagBuilder.MergeAttribute("type", _inputType.LiteralValue());
        }

        public void AddAccept(string fileType)
        {
            TagBuilder.MergeAttribute("accept", fileType);
        }

        public void AddChecked()
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
    }
}