using System.Web.Mvc;
using Tags.Encoders;

namespace Tags.HTMLTags
{
    public class InlineScript : Script
    {
        public InlineScript(string script) : base()
        {
            Content.Add(new Text(script, new PassThroughEncoder()));
        }
    }
}