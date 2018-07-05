using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class AutofocusAttributeTest : AttributeTest<SupportAutofocusAttribute>
    {
        [Test]
        public void AddAutofocus()
        {
            AssertAttributeAdded(tag => tag.AddAutofocus(), $"<test autofocus=\"autofocus\"></test>");
        }
    }
}