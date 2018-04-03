using System.Web.Mvc;

namespace Tags.HTMLTags
{
    public class InlineScript : Script
    {
        public InlineScript(string script) : base()
        {
            TagBuilder.InnerHtml = script;
        }
    }
}