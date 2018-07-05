using System;
using NUnit.Framework;
using Tags.HTMLTags;
using Tags.HTMLTags.Attributes;
using Tags.Test;

namespace Tags.Tests.HTMLTags
{
    [TestFixture]
    [Category(TestCommons.CategoryUnitTest)]
    public class FormTest
    {
        private Form _tag;

        [SetUp]
        public void SetUp()
        {
            _tag = new Form();
        }

        [Test]
        public void Ctor()
        {
            Assert.AreEqual(_tag.ToString(), "<form></form>");
        }

        [TestCase(typeof(SupportAutocompleteAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [Test]
        public void AddAcceptCharset()
        {
            _tag.AddAcceptCharset(Charset.ISO_8859_1);
            Assert.AreEqual(_tag.ToString(), $"<form accept-charset=\"{Charset.ISO_8859_1.LiteralValue()}\"></form>");
        }

        [Test]
        public void AddAction()
        {
            _tag.AddAction("https://www.example.com/some/action");
            Assert.AreEqual(_tag.ToString(), "<form action=\"https://www.example.com/some/action\"></form>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}