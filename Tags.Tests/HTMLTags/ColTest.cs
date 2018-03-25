using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ColTest
    {
        private readonly Col tag = new Col();

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(tag.ToString(), "<col></col>");
        }

        [Test]
        public void AddSpan()
        {
            tag.AddSpan(3);
            Assert.AreEqual(tag.ToString(), "<col span=\"3\"></col>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}