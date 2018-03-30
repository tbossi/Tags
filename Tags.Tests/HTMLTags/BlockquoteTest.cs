using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class BlockquoteTest
    {
        private Blockquote _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Blockquote();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<blockquote></blockquote>");
        }

        [TestCase(typeof(SupportCiteAttribute))]
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