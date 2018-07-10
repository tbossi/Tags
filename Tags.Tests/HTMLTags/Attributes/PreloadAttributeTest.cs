using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class PreloadAttributeTest : AttributeTest<SupportPreloadAttribute>
    {
        [Test]
        public void AddPreload()
        {
            AssertAttributeAdded(tag => tag.AddPreload(Preload.Metadata), $"<test preload=\"{Preload.Metadata.LiteralValue()}\"></test>");
        }
    }
}