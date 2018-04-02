using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TdTest
    {
        private Td _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Td();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<td></td>");
        }

        [TestCase(typeof(SupportColspanAttribute))]
        [TestCase(typeof(SupportRowspanAttribute))]
        [TestCase(typeof(SupportHeadersAttribute))]
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