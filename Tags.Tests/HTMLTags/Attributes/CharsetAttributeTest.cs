using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class CharsetAttributeTest : AttributeTest<SupportCharsetAttribute>
    {
        [Test]
        public void AddCharset()
        {
            AssertAttributeAdded(tag => tag.AddCharset(Charset.UTF_8), "<test charset=\"UTF-8\"></test>");
        }
    }
}