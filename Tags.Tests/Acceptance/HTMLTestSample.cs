using System;
using System.Web.Mvc;

namespace Tags.Tests.Acceptance
{
    public class HTMLTestSample
    {
        public Func<HTMLBuilder> HTMLBuilderVersionGenerator { get; set; }
        public Func<TagBuilder> TagBuilderVersionGenerator { get; set; }
        public HTMLBuilder HTMLBuilderVersion => HTMLBuilderVersionGenerator();
        public TagBuilder TagBuilderVersion => TagBuilderVersionGenerator();
        public string StringVersion { get; set; }
    }
}