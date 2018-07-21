using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
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

        [TestCase(typeof(SupportAutofocusAttribute))]
        [TestCase(typeof(SupportDisabledAttribute))]
        [TestCase(typeof(SupportFormAttribute))]
        [TestCase(typeof(SupportMultipleAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
        [TestCase(typeof(SupportRequiredAttribute))]
        [TestCase(typeof(SupportSizeAttribute))]
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