using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ColgroupTest
    {
        private Colgroup _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Colgroup();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<colgroup></colgroup>");
        }

        [TestCase(typeof(SupportSpanAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}