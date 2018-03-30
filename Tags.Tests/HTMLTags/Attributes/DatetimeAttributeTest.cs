using System;
using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DatetimeAttributeTest : AttributeTest<SupportDatetimeAttribute>
    {
        [Test]
        public void AddDatetime()
        {
            var date = new DateTime();
            AssertAttributeAdded(tag => tag.AddDatetime(date), $"<test datetime=\"{date.ToString("u")}\"></test>");
        }
    }
}