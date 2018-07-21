using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SourceTest
    {
        private Source _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Source();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<source>");
        }

        [TestCase(typeof(SupportMediaQueryAttribute))]
        [TestCase(typeof(SupportMIMETypeAttribute))]
        [TestCase(typeof(SupportSrcAttribute))]
        [TestCase(typeof(SupportSrcsetAttribute))]
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