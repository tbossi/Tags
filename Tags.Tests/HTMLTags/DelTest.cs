using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class DelTest
    {
        private Del _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Del();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<del></del>");
        }

        [TestCase(typeof(SupportCiteAttribute))]
        [TestCase(typeof(SupportDatetimeAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}