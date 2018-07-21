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
        [TestCase(typeof(SupportDisabledAttribute))]
        [TestCase(typeof(SupportFormAttribute))]
        [TestCase(typeof(SupportMaxLengthAttribute))]
        [TestCase(typeof(SupportNameAttribute))]
        [TestCase(typeof(SupportPlaceholderAttribute))]
        [TestCase(typeof(SupportReadonlyAttribute))]
        [TestCase(typeof(SupportRequiredAttribute))]
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
        public void AddRows()
        {
            _tag.AddRows(5);
            Assert.AreEqual(_tag.ToString(), "<textarea rows=\"5\"></textarea>");
        }

        [Test]
        public void AddRows_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => _tag.AddRows(-10));
        }

        [Test]
        public void AddWrap()
        {
            _tag.AddWrap(Wrap.Hard);
            Assert.AreEqual(_tag.ToString(), "<textarea wrap=\"hard\"></textarea>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.Normal);
        }
    }
}