using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class ButtonTest
    {
        private Button _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Button(ButtonType.Submit);
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<button type=\"submit\"></button>");
        }

        [TestCase(typeof(SupportAutofocusAttribute))]
        [TestCase(typeof(SupportDisabledAttribute))]
        [TestCase(typeof(SupportFormAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
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