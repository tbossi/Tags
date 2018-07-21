using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class EmbedTest
    {
        private Embed _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Embed("http://src");
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<embed src=\"http://src\">");
        }

        [TestCase(typeof(SupportHeightAttribute))]
        [TestCase(typeof(SupportWidthAttribute))]
        [TestCase(typeof(SupportMIMETypeAttribute))]
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