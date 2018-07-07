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
        [TestCase(typeof(SupportNameAttribute))]
        public void SupportedAttributes(Type supportedType)
        {
            Assert.That(supportedType.IsAssignableFrom(_tag.GetType()));
        }

        [TestCase(Method.POST)]
        [TestCase(Method.GET)]
        public void AddMethod(Method method)
        {
            _tag.AddMethod(method);
            Assert.AreEqual(_tag.ToString(), $"<form method=\"{method.LiteralValue()}\"></form>");
        }

        [Test]
        public void AddMethod_Post_EncType()
        {
            _tag.AddMethod(Method.POST, EncType.Multipart_Form_Data);
            Assert.AreEqual(_tag.ToString(), $"<form enctype=\"{EncType.Multipart_Form_Data.LiteralValue()}\" method=\"{Method.POST.LiteralValue()}\"></form>");
        }

        [Test]
        public void AddMethod_Get_NoEncType()
        {
            _tag.AddMethod(Method.GET, EncType.Multipart_Form_Data);
            Assert.AreEqual(_tag.ToString(), $"<form method=\"{Method.GET.LiteralValue()}\"></form>");
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
        public void AddNoValidate()
        {
            _tag.AddNoValidate();
            Assert.AreEqual(_tag.ToString(), "<form novalidate=\"novalidate\"></form>");
        }

        [Test]
        public void TagRenderMode()
        {
            Assert.AreEqual(_tag.TagRenderMode, System.Web.Mvc.TagRenderMode.Normal);
        }
    }
}