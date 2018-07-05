using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ControlsAttributeTest : AttributeTest<SupportControlsAttribute>
    {
        [Test]
        public void AddControls()
        {
            AssertAttributeAdded(tag => tag.AddControls(), $"<test controls=\"controls\"></test>");
        }
    }
}