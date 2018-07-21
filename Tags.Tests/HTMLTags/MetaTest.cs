using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class MetaTest
    {
        private Meta _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Meta();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<meta>");
        }

        [TestCase(typeof(SupportCharsetAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [TestCase("")]
        [TestCase("    ")]
        [TestCase(null)]
        public void AddName_ThrowsException(string content)
        {
            Assert.Throws<ArgumentException>(() => _tag.AddName(Name.Author, content));
        }

        [Test]
        public void AddName()
        {
            _tag.AddName(Name.Author, "authorName");
            Assert.AreEqual(_tag.ToString(), "<meta content=\"authorName\" name=\"author\">");
        }

        [TestCase("")]
        [TestCase("    ")]
        [TestCase(null)]
        public void AddHttpEquiv_ThrowsException(string content)
        {
            Assert.Throws<ArgumentException>(() => _tag.AddHttpEquiv(HttpEquiv.Refresh, content));
        }

        [Test]
        public void AddHttpEquiv()
        {
            _tag.AddHttpEquiv(HttpEquiv.Refresh, "50");
            Assert.AreEqual(_tag.ToString(), "<meta content=\"50\" http-equiv=\"refresh\">");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, Tags.HTMLTags.TagRenderMode.SelfClosing);
        }
    }
}