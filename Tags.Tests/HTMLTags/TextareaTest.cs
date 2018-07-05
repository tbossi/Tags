using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class TextareaTest
    {
        private Textarea _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Textarea();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<textarea></textarea>");
        }

        [TestCase(typeof(SupportAutofocusAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddCols()
        {
            _tag.AddCols(5);
            Assert.AreEqual(_tag.ToString(), "<textarea cols=\"5\"></textarea>");
        }

        [Test]
        public void AddCols_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _tag.AddCols(-10));
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}