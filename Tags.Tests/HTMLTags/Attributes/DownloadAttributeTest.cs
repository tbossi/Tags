using NUnit.Framework;
using Tags.Test;
using Tags.HTMLTags.Attributes;

namespace Tags.Tests.HTMLTags.Attributes
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DownloadAttributeTest : AttributeTest<SupportDownloadAttribute>
    {
        [Test]
        public void AddDownload()
        {
            AssertAttributeAdded(tag => tag.AddDownload("fileName"), "<test download=\"fileName\"></test>");
        }
    }
}