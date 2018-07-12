using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class OlTest
    {
        private Ol _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Ol();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<ol></ol>");
        }

        [Test]
        public void AddReversed()
        {
            _tag.AddReversed();
            Assert.AreEqual(_tag.ToString(), "<ol reversed=\"reversed\"></ol>");
        }

        [Test]
        public void AddStart()
        {
            _tag.AddStart(50);
            Assert.AreEqual(_tag.ToString(), "<ol start=\"50\"></ol>");
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