using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ObjectTest
    {
        private Object _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Object();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<object></object>");
        }

        [TestCase(typeof(SupportFormAttribute))]
        [TestCase(typeof(SupportHeightAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
        [TestCase(typeof(SupportMIMETypeAttribute))]
        [TestCase(typeof(SupportUsemapAttribute))]
        [TestCase(typeof(SupportWidthAttribute))]
        public void SupportedAttributes(System.Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddData()
        {
            _tag.AddData("file.swf");
            Assert.AreEqual(_tag.ToString(), "<object data=\"file.swf\"></object>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}