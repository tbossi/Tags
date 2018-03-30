using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class RelAttributeTest : AttributeTest<SupportRelAttribute>
    {
        [Test]
        public void AddRel()
        {
            AssertAttributeAdded(tag => tag.AddRel(Rel.Next), $"<test rel=\"{Rel.Next.LiteralValue()}\"></test>");
        }
    }
}