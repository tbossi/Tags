using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class OptionTest
    {
        private Option _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Option();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<option></option>");
        }

        [Test]
        public void AddSelected()
        {
            _tag.AddSelected();
            Assert.AreEqual(_tag.ToString(), "<option selected=\"selected\"></option>");
        }

        [TestCase(typeof(SupportDisabledAttribute))]
        [TestCase(typeof(SupportLabelAttribute))]
        [TestCase(typeof(SupportStringValueAttribute))]
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