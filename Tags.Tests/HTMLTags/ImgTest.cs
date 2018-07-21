using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ImgTest
    {
        private Img _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Img("/image.jpg", "An image");
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<img alt=\"An image\" src=\"/image.jpg\">");
        }

        [TestCase(typeof(SupportHeightAttribute))]
        [TestCase(typeof(SupportSrcsetAttribute))]
        [TestCase(typeof(SupportUsemapAttribute))]
        [TestCase(typeof(SupportWidthAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}