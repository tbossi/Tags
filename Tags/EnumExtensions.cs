using System;
using Tags.HTMLTags.Attributes;

namespace Tags
{
    public static class EnumExtensions
    {
        public static string LiteralValue(this Enum enumValue) => enumValue.ToString("f").ToLowerInvariant();

        public static string LiteralValue(this Crossorigin crossorigin)
        {
            switch (crossorigin)
            {
                case Crossorigin.Anonymous: return "anonymous";
                case Crossorigin.UseCredentials: return "use-credentials";
                default: throw new ArgumentException();
            }
        }

        public static string LiteralValue(this HttpEquiv httpEquiv)
        {
            switch (httpEquiv)
            {
                case HttpEquiv.ContentType: return "content-type";
                case HttpEquiv.DefaultStyle: return "default-style";
                case HttpEquiv.Refresh: return "refresh";
                default: throw new ArgumentException();
            }
        }

        public static string LiteralValue(this Name name)
        {
            switch (name)
            {
                case Name.ApplicationName: return "application-name";
                case Name.Author: return "author";
                case Name.Description: return "description";
                case Name.Generator: return "generator";
                case Name.Keywords: return "keywords";
                case Name.Viewport: return "viewport";
                default: throw new ArgumentException();
            }
        }

        public static string LiteralValue(this Sandbox sandbox)
        {
            switch (sandbox)
            {
                case Sandbox.AllowForms: return "allow-forms";
                case Sandbox.AllowPointerLock: return "allow-pointer-lock";
                case Sandbox.AllowPopups: return "allow-popups";
                case Sandbox.AllowSameOrigin: return "allow-same-origin";
                case Sandbox.AllowScripts: return "allow-scripts";
                case Sandbox.AllowTopNavigation: return "allow-top-navigation";
                default: throw new ArgumentException();
            }
        }
    }
}