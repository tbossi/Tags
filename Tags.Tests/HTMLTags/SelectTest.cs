using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class SelectTest
    {
        private Select _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Select();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<select></select>");
        }

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