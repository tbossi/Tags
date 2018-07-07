using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class LabelAttributeTest : AttributeTest<SupportLabelAttribute>
    {
        [Test]
        public void AddFor()
        {
            AssertAttributeAdded(tag => tag.AddLabel("some_label"), "<test label=\"some_label\"></test>");
        }
    }
}