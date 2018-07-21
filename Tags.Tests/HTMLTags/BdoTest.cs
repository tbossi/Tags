using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BdoTest
    {
        [Test]
        public void Ctor()
        {
            Assert.AreEqual(new Bdo(Dir.Ltr).ToString(), "<bdo dir=\"ltr\"></bdo>");
            Assert.AreEqual(new Bdo(Dir.Rtl).ToString(), "<bdo dir=\"rtl\"></bdo>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(new Bdo(Dir.Ltr).TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}